from bs4 import BeautifulSoup
import requests

def first_page(url):
    arr = []
    finalurl = url.format(url)
    res = requests.get(finalurl).text
    soup = BeautifulSoup(res,'html.parser')
    for t, c in zip(soup.select('.image_container >a>img'),soup.select('p.price_color')):
        y = {'Ttile': t['alt'],'Cost': c.text[1:]}
        arr.append(y)
    return arr


print(first_page('http://books.toscrape.com/catalogue/page-1.html'))



