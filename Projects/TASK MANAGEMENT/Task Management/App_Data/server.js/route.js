app.post('/submit-form', (req, res) => {
    const formData = req.body;

    const query = 'INSERT INTO tms.new_user (first_name, last_name, email_id, user_role, password, confirm_password) VALUES (?, ?, ?)';
    const values = [formData.first_name, formData.last_name, formData.email_id, formData.user_role, formData.password, formData.confirm_password];

    connection.query(query, values, (err, result) => {
        if (err) throw err;
        console.log('Form data saved to MySQL database!');
        res.redirect('/thank-you');
    });
});
