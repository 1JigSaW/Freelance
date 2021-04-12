
from flask import Flask, render_template, request, flash, url_for, redirect, session
from flask_migrate import Migrate
from flask_sqlalchemy import SQLAlchemy
from forms import BookForm, SignUpForm
import os
from werkzeug.security import generate_password_hash, check_password_hash
from bson.objectid import ObjectId
from flask_login import LoginManager, UserMixin
from flask_login.utils import current_user, login_user, logout_user, login_required
basedir = os.path.abspath(os.path.dirname(__file__))


app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///' + os.path.join(basedir, 'admin.db')

app.config['SECRET_KEY'] = 'mysecret'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
db = SQLAlchemy(app)

migrate = Migrate(app, db)
login_manager = LoginManager(app)
login_manager.login_view = 'login'



class Accounts(UserMixin, db.Model):
    user_id = db.Column(db.Integer, primary_key=True)
    account_username = db.Column(db.String(15), unique=True, nullable=True)
    account_email = db.Column(db.String(100), unique=True, nullable=True)
    password = db.Column(db.String(15), nullable=False)

    def __repr__(self):
        return '{}'.format(self.account_username)

    def __str__(self):
        return self.account_username

    def get_id(self):
           return (self.user_id)

# class UserView(ModelView):
#     column_exclude_list = ['password']
#     column_display_pk = True
#     can_export = True

#     def is_accessible(self):
#         return current_user.is_authenticated

#     def inaccessible_callback(self, name, **kwargs):
#         return redirect(url_for('login'))

class Category(db.Model):
    __tablename__ = "category"
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String)
    description = db.Column(db.String)
    book1 = db.Column(db.String)
    book2 = db.Column(db.String)
    book3 = db.Column(db.String)

    def __init__(self, name, description, book1, book2, book3):
        self.name = name
        self.description = description
        self.book1 = book1
        self.book2 = book2
        self.book3 = book3

    def __str__(self):
        if self.name==None:
            return "ERROR-CUSTOMER NAME IS NULL"
        return self.name

    def __repr__(self):
        return str(self.name) if self.name else ''

    def get_id(self):
        return (self.id)



class Author(db.Model):
    __tablename__ = "author"
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String, nullable=False)

    def __str__(self):
        if self.name==None:
            return "ERROR-CUSTOMER NAME IS NULL"
        return self.name

    def __repr__(self):
        return '{}'.format(self.name)

class Book(db.Model):
    __tablename__ = "book"
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String, unique=True)
    description = db.Column(db.String)
    author_id = db.Column(db.Integer, db.ForeignKey('author.id'), nullable=False)
    category_id = db.Column(db.Integer, db.ForeignKey('category.id'), nullable=False)
    category = db.relationship('Category', backref=db.backref('Book', lazy=True))
    author = db.relationship('Author', backref=db.backref('Book', lazy=True))



migrate.init_app(app, db)

@login_manager.user_loader
def load_user(user_id):
    return Accounts.query.get(int(user_id))

@app.route("/login")
def login():
    return render_template("login.html")

@app.route("/login", methods=["POST"])
def login_post():
    if request.method == 'POST':
        account_username = request.form.get("user")
        password = request.form.get("password")
        user = Accounts.query.filter_by(account_username=account_username).first()
        if not user or not password:
            flash("Invalid credentials")
            return redirect(url_for("login"))
            
        login_user(user, remember=True)

        if 'next' in session:
            next = session['next']


    session['next'] = request.args.get('next')
    return redirect(url_for('books'))

@app.route("/logout")
@login_required
def logout():
    logout_user()
    return redirect(url_for("index"))

@app.route('/index/')
def index():
    return render_template('index.html')


@app.route('/browse/')
def browse():
    if request.method == 'GET':
        categories = Category.query.all()  
        return render_template('browse.html', categories=categories)


@app.route('/browse/<category>')
def category(category):
    if request.method == 'GET':
        categories2 = Category.query.all()  
        return render_template('category.html', categories2=categories2, category=category)

@app.route('/<category>/<book>')
def book(category, book):
    if request.method == 'GET':
        books = Book.query.filter(Book.author_id == Author.id).all() 
        author = Author.query.filter(Author.id == Book.id).all()
        return render_template('book.html', books=books, book=book, author=author)

@app.route("/admin/book")
def books():
    books = Book.query.all()
    return render_template("books.html", books=books)

@app.route("/admin/author")
def authors():
    authors = Author.query.all()
    return render_template("authors.html", authors=authors)

@app.route("/admin/category")
def categories():
    categories = Category.query.all()
    return render_template("categories.html", categories=categories)

@app.route("/admin/account")
def accounts():
    accounts = Accounts.query.all()
    return render_template("accounts.html", accounts=accounts)

@app.route("/admin/create/book", methods=("GET", "POST"))
def create_book():
    if request.method == "POST":
        title = request.form["title"]
        description = request.form["description"]
        author_id = request.form["author_id"]
        category_id = request.form["category_id"]

        error = None

        if not title:
            error = "Name is required."

        if error is None:
            book = Book(
                title=title,
                description=description,
                author_id=author_id,
                category_id=category_id,
            )
            db.session.add(book)
            db.session.commit()

            return redirect(url_for("books"))

        flash(error)

    authors = Author.query.all()
    categories = Category.query.all()
    return render_template("book_form.html", authors=authors, categories=categories)


@app.route("/admin/edit/book/<id>", methods=("GET", "POST"))
def edit_book(id):
    book = Book.query.get_or_404(id)

    if request.method == "POST":
        book.title = request.form["title"]
        book.description = request.form["description"]
        book.author_id = request.form["author_id"]
        book.category_id = request.form["category_id"]

        error = None

        if not request.form["title"]:
            error = "Name is required."

        if error is None:
            db.session.commit()

            return redirect(url_for("books"))

        flash(error)

    authors = Author.query.all()
    categories = Category.query.all()
    return render_template(
        "book_form.html",
        title=book.title,
        description=book.description,
        authors=authors,
        author_id=book.author_id,
        categories=categories,
        category_id=book.category_id,
    )


@app.route("/admin/delete/book/<id>")
def delete_book(id):
    book = Book.query.get_or_404(id)
    db.session.delete(book)
    db.session.commit()

    return redirect(url_for("books"))


@app.route("/admin/create/category", methods=("GET", "POST"))
def create_category():
    if request.method == "POST":
        name = request.form["name"]
        description = request.form["description"]
        book1 = request.form["book1"]
        book2 = request.form["book2"]
        book3 = request.form["book3"]

        error = None

        if not name:
            error = "Name is required."

        if error is None:
            category = Category(
                name=name, 
                description=description, 
                book1=book1,
                book2=book2,
                book3=book3
                )
            db.session.add(category)
            db.session.commit()

            return redirect(url_for("books"))

        flash(error)

    return render_template("category_form.html")

@app.route("/admin/edit/category/<id>", methods=("GET", "POST"))
def edit_category(id):
    category = Category.query.get_or_404(id)

    if request.method == "POST":
        category.name = request.form["name"]
        category.description = request.form["description"]
        category.book1 = request.form["book1"]
        category.book1 = request.form["book2"]
        category.book1 = request.form["book3"]

        error = None

        if not request.form["name"]:
            error = "Name is required."

        if error is None:
            db.session.commit()

            return redirect(url_for("books"))

        flash(error)

    return render_template(
        "category_form.html",
        name=category.name,
        description=category.description,
        book1=category.book1,
        book2=category.book2,
        book3=category.book3,
    )

@app.route("/admin/delete/category/<id>")
def delete_category(id):
    category = Category.query.get_or_404(id)
    db.session.delete(category)
    db.session.commit()

    return redirect(url_for("books"))

@app.route("/admin/create/author", methods=("GET", "POST"))
def create_author():
    if request.method == "POST":
        name = request.form["name"]

        error = None

        if not name:
            error = "Name is required."

        if error is None:
            author = Author(name=name)
            db.session.add(author)
            db.session.commit()

            return redirect(url_for("books"))

        flash(error)

    return render_template("author_form.html")

@app.route("/admin/edit/author/<id>", methods=("GET", "POST"))
def edit_author(id):
    author = Author.query.get_or_404(id)

    if request.method == "POST":
        author.name = request.form["name"]

        error = None

        if not request.form["name"]:
            error = "Name is required."

        if error is None:
            db.session.commit()

            return redirect(url_for("books"))

        flash(error)

    return render_template(
        "author_form.html",
        name=author.name,
    )

@app.route("/admin/delete/author/<id>")
def delete_author(id):
    author = Author.query.get_or_404(id)
    db.session.delete(author)
    db.session.commit()

    return redirect(url_for("books"))

@app.route("/admin/create/account", methods=("GET", "POST"))
def create_account():
    if request.method == "POST":
        account_username = request.form["account_username"]
        account_email = request.form["account_email"]
        password = request.form["password"]

        error = None

        if not account_username:
            error = "Name is required."

        if error is None:
            account = Accounts(
                account_username=account_username,
                account_email=account_email,
                password=password
                )
            db.session.add(account)
            db.session.commit()

            return redirect(url_for("books"))

        flash(error)

    return render_template("account_form.html")

@app.route("/admin/edit/account/<user_id>", methods=("GET", "POST"))
def edit_account(user_id):
    account = Accounts.query.get_or_404(user_id)

    if request.method == "POST":
        account.account_username = request.form["account_username"]
        account.account_email = request.form["account_email"]
        account.password = request.form["password"]

        error = None

        if not request.form["account_username"]:
            error = "Name is required."

        if error is None:
            db.session.commit()

            return redirect(url_for("books"))

        flash(error)

    return render_template(
        "account_form.html",
        account_username=account.account_username,
        account_email=account.account_email,
        password=account.password
    )

@app.route("/admin/delete/account/<user_id>")
def delete_account(user_id):
    account = Accounts.query.get_or_404(user_id)
    db.session.delete(account)
    db.session.commit()

    return redirect(url_for("books"))