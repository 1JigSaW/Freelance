$groups = Get-LocalGroup
$groupFound = $false
foreach ($gr in $groups) {
    if ($gr.Name -eq "MathUsers") {
        Write-Host "Group found"
        $groupFound = $true
        break
    }
}

if (!$groupFound) {
    Write-Host "Group not found"
    Write-Host "Try to add group"
    New-LocalGroup MathUsers | Out-Null
    Write-Host "Group created"
}

$users = Get-LocalUser
$userFound = $false
foreach ($u in $users) {
    if ($u.Name -eq "Vasya") {
        Write-Host "User found"
        $userFound = $true
        break
    }
}

if (!$userFound) {
    Write-Host "User not found"
    Write-Host "Try to add user"

    $chars = @();
    $random = [System.Random]::new();
    $min = [int][char]'0'
    $max = [int][char]'Z'
    for ($i = 0; $i -le 5; $i++){
        $chars += [char]($random.Next($max - $min) + $min)
    }
    $str = $chars -join $null

    $pass = ConvertTo-SecureString $str -AsPlainText -Force

    New-LocalUser -Name Vasya -Password $pass | Out-Null
    Write-Host "User created"
    Write-Host "Password: " $str
}

$members = Get-LocalGroupMember -Group "MathUsers"
$userInGroup = $false
foreach ($m in $members) {
    if ($m.Name -eq $env:computername + "\Vasya") {
        Write-Host "User in group"
        $userInGroup = $true
        break
    }
}

if (!$userInGroup) {
    Add-LocalGroupMember -Group "MathUsers" -Member "Vasya" | Out-Null
    Write-Host "User was added to group"
}

###########################

$regPath = "HKCU:\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
$name = "DiskX"
$value = "subst x: C:\Users"
$item = Get-Item $regPath

if ($item.GetValue($name) -eq $null) {
    New-ItemProperty -Path $regPath -Name $name -Value $value -PropertyType String | Out-Null
}
else {
    Set-ItemProperty -Path $regPath -Name $name -Value $value | Out-Null
}