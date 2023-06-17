const mysql = require('mysql');

const connection = mysql.createConnection({
  host: 'localhost',
  user: 'mysql',
  password: 'Sakhare@123',
  database: 'tms',
  port : '3307'

});

connection.connect((error) => {
  if (error) {
    console.error('Database connection failed: ', error);
  } else {
    console.log('Connected to database');
  }
});
