import click
import os
import shutil

@click.group()
def cli():
    pass

@click.command()
@click.argument('folder')
def create(folder):
    if not os.path.isdir(folder):
        os.mkdir(folder)
    else:
        print(f'Папка {folder} уже существует')


@click.command()
@click.argument('folder')
@click.option('-f', is_flag=True)
def delete(f,folder):
    if f:
        shutil.rmtree(folder)
    else:
        try:
             os.rmdir(folder)
        except:
             print(f"папка {folder} не пуста")


cli.add_command(create)
cli.add_command(delete)

if __name__ == '__main__':
    cli()