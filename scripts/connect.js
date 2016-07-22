//First you have to install the MySQL Package
//CMD-Line: npm install mysql
//The "package.json" must be in the same directory
var mysql = require('mysql');

var connection = mysql.createConnection({
  host: 'localhost',
  user: 'root',
  password: '',
  database: 'db_recontime'
});
connection.connect();


connection.query('select * from lehrlinge', function(err, result) {
  console.log(result);
});


