<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="jobportel1.home" %>
<!DOCTYPE html>

<html>
<head>
    <title>Homepage</title>
    <link rel="stylesheet" type="text/css" href="Styles/Site.css" />
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
    <style>
        .nav {
    position: fixed;
    top: 0;
    left: 0;
    height: 100%;
    width: 150px;
    background-color: black;
    border-right: 1px solid #ccc;
    
}
        h5   {color: white;}


.nav ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    
}

.nav li {
    border-bottom: 1px solid #ccc;
    padding: 30px;
    
}

.nav li a {
    display: block;
    color: #666;
    text-decoration: none;
    color:white
}



.content {
    margin-left: 160px;
    padding: 20px;
}
.logo {
    display: flex;
    align-items: center;
    justify-content: center;
    height: 80px;
    background-color: #fff;
    border-radius: 50%;
    margin: 10px;
    box-shadow: 0 0 5px rgba(0, 0, 0, 0.3);
}

.logo img {
    max-width: 100%;
    max-height: 100%;
    border-radius: 50%;
}
.navbar-nav li {
    transition: opacity 0.2s ease-in-out;
}

a {
  color: red;
  position: relative;
  text-decoration: none;
}

a::before {
  content: '';
  position: absolute;
  width: 90%;
  height: 4px;
  border-radius: 4px;
  background-color: red;
  bottom: 0;
  left: 0;
  transform-origin: right;
  transform: scaleX(0);
  transition: transform .3s ease-in-out;
}

a:hover::before {
  transform-origin: left;
  transform: scaleX(1);
}
  


    </style>
</head>
<body>
    <nav>
    <div class="nav" >
         <div class="logo">
        <img src="https://t3.ftcdn.net/jpg/03/21/64/56/360_F_321645620_Qs6OEAZawx7LiAuuHQNgj89iFIJNlV52.jpg" alt="Logo" />
        
    </div>
        
    <h5>Welcome,<br />
        <%: Session["UserName"] %></h5>


        <ul>
            <li><a href="Login.aspx">Login</a></li>
            <li><a href="Register.aspx">Register</a></li>
            <li><a href="addjob.aspx">Add Jobs</a></li>
            <li><a href="Aboutus.aspx">About Us</a></li>
            <li><a href="update.aspx">Update profile</a></li>
             
            
        </ul>

    </div>
        </nav>
    <div class="content">
        <h1>List of Jobs</h1>
        <hr />
        <ul>
            <div class="row">
    <% foreach (var job in Jobs) { %>
   <div class="col-md-4">
    <div class="card mb-4">
        <div class="card-body">
            <h5 class="card-title"><%: job.JobTitle %></h5>
            <h6 class="card-subtitle mb-2 text-muted"><%: job.JobLocation %></h6>
            <p class="card-text"><%: job.JobDescription %></p>
            <ul class="list-unstyled">
                <li><strong>Type:</strong> <%: job.JobType %></li>
                <li><strong>Salary:</strong> <%: job.JobSalary %></li>
                <li><strong>Email:</strong> <%: job.email %></li>
                <li><strong>Compny name:</strong> <%: job.company_name %></li>
            </ul>
        </div>

    </div>
</div>

<% } %>
</div>
    
        </ul>
    </div>
    
    <!-- Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    </div>
</body>
</html>
