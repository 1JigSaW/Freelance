import platform
import shutil
import os
import time 

try:
	my_file = open("ini_file.txt", "w")
	my_file.write("[info]\n")
	for data in platform.architecture():
		my_file.write(f'{data} ')

	total, used, free = shutil.disk_usage("\\")
	my_file.write("\n\nTotal: %d GB\n" % (total // (2**30)))
	my_file.write("Used: %d GB\n" % (used // (2**30)))
	my_file.write("Free: %d GB\n" % (free // (2**30)))

	my_file.write("\n[entry]\n")
	my_file.write(f'{os.getcwd()}\n\n')

	os.chdir(os.getcwd())
	for root, dirs, files in os.walk(".", topdown = False):
		for name in dirs:
			my_file.write("[file]\n")
			my_file.write(f'{os.path.join(root, name)}\n')
			my_file.write('\n[creation date]\n')
			my_file.write("created: %s\n" % time.ctime(os.path.getctime(os.path.join(root, name))))
			my_file.write('\n[content]\n')
			for name in os.listdir(os.path.join(root, name)):
				if os.path.isdir(os.path.join(os.path.join(root, name), name)):
					my_file.write(f'{name}\n')
		for name in files:
			print(name)
			if (name != "ini_file.py") and (name != "ini_file.txt"):
				my_file.write('\n[file]\n')
				my_file.write(f'{os.path.join(root, name)}\n')
				my_file.write('\n[creation date]\n')
				my_file.write("created: %s\n" % time.ctime(os.path.getctime(os.path.join(root, name))))
				my_file.write('\n[content]\n')
				file = open(os.path.join(root, name), "r")
				for line in file:
					my_file.write(line)
				my_file.write('\n')
				file.close()
	my_file.close()
except Exception:
	print('Error')