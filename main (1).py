
import sys
if len(sys.argv) <= 2: 
	import subprocess
	subprocess.run(["/bin/bash", "score.sh", sys.argv[0]],shell=True) 
import argparse
import os
import shutil
def create ():
    parser = argparse.ArgumentParser()
    parser.add_argument('create')
    parser.add_argument('name')
    return parser

def delete ():
    parser = argparse.ArgumentParser()
    parser.add_argument('delete')
    parser.add_argument('name')
    return parser

def fdelete():
     parser = argparse.ArgumentParser()
     parser.add_argument ('-f')
     parser.add_argument ('name')
     return parser



if __name__ == '__main__':
	if len(sys.argv) >= 2:
		if sys.argv[1]=='create':
			parser = create()
			create = parser.parse_args()
			if not os.path.isdir(create.name):
				os.mkdir(create.name)
			else:
				print(f'Папка {create.name} уже существует')
		elif sys.argv[1:]=='delete':
			parser = delete()
			delete = parser.parse_args()
			try:
				os.rmdir(delete.name)
			except:
				print(f"папка {delete.name} не пуста")
		else:
			parser = fdelete()
			fdelete = parser.parse_args()

			shutil.rmtree(fdelete.name)
	else: 
		print('Несоответствующая команда')
