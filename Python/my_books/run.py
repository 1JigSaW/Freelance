from app import app

if __name__ == '__main__':
	add_routes(app)
    app.run(debug=True)