<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login Form.aspx.cs" Inherits="Login_And_Regs_Temp.in_Bootstrap.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
     <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">
  <h2>Login Form</h2>
  <p></p>
  <form>
    <div class="form-group">
      <label for="usr">Name:</label>
      <input type="text" class="form-control" id="usr">
    </div>
    <div class="form-group">
      <label for="pwd">Password:</label>
      <input type="password" class="form-control" id="pwd">
    </div>
  </form>
</div>
        <div class="container">
  <h2>Choose Gender</h2>
  <form>
    <div class="checkbox">
      <label><input type="checkbox" value="">Male</label>
    </div>
    <div class="checkbox">
      <label><input type="checkbox" value="">Female</label>
    </div>
    <div class="checkbox disabled">
      <label><input type="checkbox" value="" disabled>Other</label>
    </div>
  </form>
</div>
        <div class="container">
  <h2>Please Login By clicking Below</h2>
  <button type="button" class="btn btn-primary btn-lg">Login</button>
  <button type="button" class="btn btn-primary">Login</button>    
  <button type="button" class="btn btn-primary btn-sm">Login</button>
  <button type="button" class="btn btn-primary btn-xs">Login</button>
</div>



    </form>
</body>
</html>
