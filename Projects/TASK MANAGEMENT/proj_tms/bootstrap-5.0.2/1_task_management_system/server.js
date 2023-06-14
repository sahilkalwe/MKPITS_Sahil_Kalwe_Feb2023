const express = require('express');
const bodyParser = require('body-parser');

const app = express();
const port = 3305;

app.use(bodyParser.urlencoded({ extended: false }));

app.post('/submit', (req, res) => {
  const first_name = req.body.first_name;
  const last_name = req.body.last_name;
  const email_id= req.body.email_id;
  const user_role = req.body.user_role;
  const password = req.body.password;
  const confirm_password = req.body.confirm_password;
  
  const query =`INSERT INTO new_users (first_name,last_name, email_id,user_role, password,confirm_password) 
  VALUES ('${first_name}','${last_name}', '${email_id}','${user_role}', '${password}', '${confirm_password}',)`;

  connection.query(query, (error, result) => {
    if (error) {
      console.error('Error saving data: ', error);
      res.send('Error saving data');
    } else {
      console.log('Data saved successfully');
      res.send('Data saved successfully');
    }
  });
});

app.listen(port, () => {
  console.log(`Server listening on port ${port}`);
});
