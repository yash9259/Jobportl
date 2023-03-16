<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="jobportel1.Login" %>



<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Login Form</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                <div class="card border-0 shadow rounded-3 my-5">
                    <div class="card-body p-4 p-sm-5">
                        <h5 class="card-title text-center mb-5 fw-light fs-5">Sign In</h5>
                        <form runat="server">
                            <div class="form-floating mb-3">
                                <asp:TextBox ID="email" CssClass="form-control" runat="server" TextMode="Email"></asp:TextBox>
                                <label for="floatingInput">Email address</label>
                            </div>
                            <div class="form-floating mb-3">
                                <asp:TextBox ID="password" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                                <label for="floatingPassword">Password</label>
                            </div>

                           <div class="d-grid">
                               <asp:Button ID="submit" runat="server" CssClass="btn btn-primary btn-login text-uppercase fw-bold" Text="Sign in" OnClick="submit_Click" />
                            </div>
                            <hr class="my-4">

                            <div class="d-grid">
                                <i class="fab fa-facebook-f me-2"></i><a href="Register.aspx" style="text-decoration:none">  New user register here</a>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-6M+5Vy5fNvRY1bS5pS9LV1BxGlD+6gPb6E8fElmKb6rkMZwOqgqckY1i9QV7oAOh" crossorigin="anonymous"></script>
</body>
</html>
