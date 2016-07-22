var mysql = require('mysql');

var connection = mysql.createConnection({
  host: 'localhost',
  user: 'root',
  password: '',
  database: 'db_recontime'
});
connection.connect();

connection.query('select lehrlingeID from lehrlinge', function(err, result) {
	console.log(result);
});

connection.query('select Name from lehrlinge', function(err, result) {
	console.log(result);
});