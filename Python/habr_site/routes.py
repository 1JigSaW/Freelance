from flask import Flask, render_template, request, flash, url_for, redirect, session
import os
from datetime import datetime
from flask_sqlalchemy import SQLAlchemy
from flask_migrate import Migrate
from flask_admin import Admin, AdminIndexView
from flask_admin.contrib.sqla import ModelView
from flask_login import LoginManager, UserMixin
from flask_login.utils import current_user, login_user, logout_user, login_required
from forms import PostForm
import datetime

basedir = os.path.abspath(os.path.dirname(__file__))
app = Flask(__name__)
app.debug = True
app.config['SECRET_KEY'] = 'root'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///' + os.path.join(basedir, 'database.db')
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
db = SQLAlchemy(app)
migrate = Migrate(app, db)

login_manager = LoginManager(app)
login_manager.login_view = 'login'

class User(UserMixin, db.Model):
    __tablename__ = "user"
    id = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(64), index=True, unique=True)
    password = db.Column(db.String(128))

    def __repr__(self):
        return self.username

class Author(db.Model):
    __tablename__ = "author"
    id = db.Column(db.Integer, primary_key=True)
    email = db.Column(db.String)
    name = db.Column(db.String)
    password = db.Column(db.String(128))

    def __repr__(self):
        return self.name

class Theme(db.Model):
    __tablename__ = "theme"
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String)

    def __repr__(self):
        return self.title

    def __str__(self):
        return self.title

class Tags(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String(140))

    def __repr__(self):
        return self.title

class MyDateTime(db.TypeDecorator):
    impl = db.DateTime
    
    def process_bind_param(self, value, dialect):
        if type(value) is str:
            return datetime.datetime.strptime(value, '%Y-%m-%d %H:%M:%S')
        return value

class Post(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String)
    body = db.Column(db.String)
    timestamp = db.Column(MyDateTime, default=datetime.datetime.now)
    author_id = db.Column(db.Integer, db.ForeignKey('author.id'))
    theme_id = db.Column(db.Integer, db.ForeignKey('theme.id'))
    tags_id = db.Column(db.Integer, db.ForeignKey('tags.id'))
    author = db.relationship('Author')
    theme = db.relationship('Theme')
    tags = db.relationship('Tags')

    # def __init__(self, author, theme, tags):
    #     self.author = author
    #     self.theme = theme
    #     self.tags = tags

    def __repr__(self):
        return self.title

    def __str__(self):
        return self.title


@login_manager.user_loader
def load_user(id):
    return User.query.get(int(id))

@app.route("/login", methods=["POST"])
def login_post():
    if request.method == 'POST':
        kek = User.query.all()
        for i in kek:
            print(i.password)
        username = request.form.get("user")
        password = request.form.get("password")
        user = User.query.filter_by(username=username).first()
        if not user or not password:
            flash("Invalid credentials")
            return redirect(url_for("login"))
            
        login_user(user, remember=True)

        if 'next' in session:
            next = session['next']


    session['next'] = request.args.get('next')
    return redirect(url_for('index'))

@app.route("/logout")
@login_required
def logout():
    logout_user()
    return redirect(url_for("index"))

@app.route('/')
def index():
    all_themes = Theme.query.all()
    all_posts = Post.query.all()
    return render_template('index.html', all_posts=all_posts, all_themes=all_themes)

@app.route('/<theme_title>')
def theme(theme_title):
    post_theme = Post.query.all()
    theme_st = theme_title
    return render_template('theme.html', theme_title=theme_title, post_theme=post_theme, theme_st=theme_st)

@app.route('/news')
def news():
    all_posts_time = Post.query.order_by(Post.timestamp)
    return render_template('news.html', all_posts_time=all_posts_time)

@app.route('/authors')
def authors():
    all_authors = Post.query.all()
    return render_template('authors.html', all_authors=all_authors)

@app.route('/authors/<author>')
def author(author):
    if request.method == 'GET':
        all_posts_time = Post.query.all()
        auth = author
        return render_template('sort.html', all_posts_time=all_posts_time, auth=auth)


@app.route("/login")
def login():
    return render_template("login.html")

@app.route("/admin/posts")
def posts():
    posts = Post.query.all()
    return render_template("posts.html", posts=posts)

@app.route("/admin/authors")
def authors_2():
    authors = Author.query.all()
    return render_template("authors_2.html", authors=authors)

@app.route("/admin/themes")
def themes():
    themes = Theme.query.all()
    return render_template("themes.html", themes=themes)

@app.route("/admin/tags")
def tags():
    tags = Tags.query.all()
    return render_template("tags.html", tags=tags)

@app.route("/admin/users")
def users():
    users = User.query.all()
    return render_template("users.html", users=users)

@app.route("/admin/create/post", methods=("GET", "POST"))
def create_post():
    if request.method == "POST":
        title = request.form["title"]
        body = request.form["body"]
        timestamp = request.form["timestamp"]
        author_id = request.form["author_id"]
        theme_id = request.form["theme_id"]
        tags_id = request.form["tags_id"]

        error = None

        if not title:
            error = "Name is required."

        if error is None:
            post = Post(
                title=title,
                body=body,
                timestamp=timestamp,
                author_id=author_id,
                theme_id=theme_id,
                tags_id=tags_id
            )
            db.session.add(post)
            db.session.commit()

            return redirect(url_for("posts"))

        flash(error)

    themes = Theme.query.all()
    authors = Author.query.all()
    tags = Tags.query.all()
    return render_template("post_form.html", authors=authors, 
        themes=themes, tags=tags)


@app.route("/admin/edit/post/<id>", methods=("GET", "POST"))
def edit_post(id):
    post = Post.query.get_or_404(id)

    if request.method == "POST":
        post.title = request.form["title"]
        post.body = request.form["body"]
        post.timestamp = request.form["timestamp"]
        post.author_id = request.form["author_id"]
        post.theme_id = request.form["theme_id"]
        post.tags_id = request.form["tags_id"]

        error = None

        if not request.form["title"]:
            error = "Name is required."

        if error is None:
            db.session.commit()

            return redirect(url_for("posts"))

        flash(error)

    themes = Theme.query.all()
    authors = Author.query.all()
    tags = Tags.query.all()
    return render_template(
        "post_form.html",
        title=post.title,
        body=post.body,
        timestamp=post.timestamp,
        authors=authors,
        author_id=post.author_id,
        themes=themes,
        theme_id=post.theme_id,
        tags=tags,
        tags_id=post.tags_id
    )


@app.route("/admin/delete/post/<id>")
def delete_post(id):
    post = Post.query.get_or_404(id)
    db.session.delete(post)
    db.session.commit()

    return redirect(url_for("posts"))


@app.route("/admin/create/theme", methods=("GET", "POST"))
def create_theme():
    if request.method == "POST":
        title = request.form["title"]

        error = None

        if not title:
            error = "Name is required."

        if error is None:
            theme = Theme(
                title=title, 
                )
            db.session.add(theme)
            db.session.commit()

            return redirect(url_for("themes"))

        flash(error)

    return render_template("theme_form.html")

@app.route("/admin/edit/theme/<id>", methods=("GET", "POST"))
def edit_theme(id):
    theme = Theme.query.get_or_404(id)

    if request.method == "POST":
        theme.title = request.form["title"]

        error = None

        if not request.form["title"]:
            error = "Name is required."

        if error is None:
            db.session.commit()

            return redirect(url_for("themes"))

        flash(error)

    return render_template(
        "theme_form.html",
        title=theme.title,
    )

@app.route("/admin/delete/theme/<id>")
def delete_theme(id):
    theme = Theme.query.get_or_404(id)
    db.session.delete(theme)
    db.session.commit()

    return redirect(url_for("themes"))

@app.route("/admin/create/author", methods=("GET", "POST"))
def create_author():
    if request.method == "POST":
        name = request.form["name"]
        email = request.form["email"]
        password = request.form["password"]

        error = None

        if not name:
            error = "Name is required."

        if error is None:
            author = Author(
                name=name,
                email=email,
                password=password)
            db.session.add(author)
            db.session.commit()

            return redirect(url_for("authors_2"))

        flash(error)

    return render_template("author_form.html")

@app.route("/admin/edit/author/<id>", methods=("GET", "POST"))
def edit_author(id):
    author = Author.query.get_or_404(id)

    if request.method == "POST":
        author.name = request.form["name"]
        author.email = request.form["email"]
        author.password = request.form["password"]

        error = None

        if not request.form["name"]:
            error = "Name is required."

        if error is None:
            db.session.commit()

            return redirect(url_for("authors_2"))

        flash(error)

    return render_template(
        "author_form.html",
        name=author.name,
        email=author.email,
        password=author.password
    )

@app.route("/admin/delete/author/<id>")
def delete_author(id):
    author = Author.query.get_or_404(id)
    db.session.delete(author)
    db.session.commit()

    return redirect(url_for("authors_2"))

@app.route("/admin/create/tags", methods=("GET", "POST"))
def create_tags():
    if request.method == "POST":
        title = request.form["title"]

        error = None

        if not title:
            error = "Name is required."

        if error is None:
            tags = Tags(
                title=title, 
                )
            db.session.add(tags)
            db.session.commit()

            return redirect(url_for("tags"))

        flash(error)

    return render_template("tags_form.html")

@app.route("/admin/edit/tags/<id>", methods=("GET", "POST"))
def edit_tags(id):
    tags = Tags.query.get_or_404(id)

    if request.method == "POST":
        tags.title = request.form["title"]

        error = None

        if not request.form["title"]:
            error = "Name is required."

        if error is None:
            db.session.commit()

            return redirect(url_for("tags"))

        flash(error)

    return render_template(
        "tags_form.html",
        title=tags.title,
    )

@app.route("/admin/delete/tags/<id>")
def delete_tags(id):
    tags = Tags.query.get_or_404(id)
    db.session.delete(tags)
    db.session.commit()

    return redirect(url_for("tags"))

@app.route("/admin/create/user", methods=("GET", "POST"))
def create_user():
    if request.method == "POST":
        username = request.form["username"]
        password = request.form["password"]

        error = None

        if not username:
            error = "Name is required."

        if error is None:
            user = User(
                username=username,
                password=password
                )
            db.session.add(user)
            db.session.commit()

            return redirect(url_for("users"))

        flash(error)

    return render_template("user_form.html")

@app.route("/admin/edit/user/<id>", methods=("GET", "POST"))
def edit_user(id):
    user = User.query.get_or_404(id)

    if request.method == "POST":
        user.username = request.form["username"]
        user.password = request.form["password"]

        error = None

        if not request.form["username"]:
            error = "Name is required."

        if error is None:
            db.session.commit()

            return redirect(url_for("users"))

        flash(error)

    return render_template(
        "user_form.html",
        username=user.username,
        password=user.password
    )

@app.route("/admin/delete/user/<id>")
def delete_user(id):
    user = User.query.get_or_404(id)
    db.session.delete(user)
    db.session.commit()

    return redirect(url_for("users"))