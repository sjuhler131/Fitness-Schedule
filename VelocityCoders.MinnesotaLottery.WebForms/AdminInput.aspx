<%@ Page Language="C#" AutoEventWireup="true" Theme="Main" CodeBehind="AdminInput.aspx.cs" Inherits="VelocityCoders.FitnessSchedule.WebForms.AdminInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrator Input</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />

    <style>
       
    </style>
</head>
<body>
    <div class="form">
        <form name="adminInput" runat="server" action="Thanks.aspx" method="get">
           <div class="datagrid">
             <table id="table1">
                 <caption>Administrator Input</caption>
                <thead>
                <tr>
                    <th>
                        Item
                    </th>
                    <th>
                        Selection
                    </th>
                </tr>
            </thead>
            <tbody>
            <tr id="tr1" class="blueBorder">
                <td id="tr1td1" class="redborder">First Name</td>
                <td id="tr1td2" class="redborder">
                    <input type="text" name="firstName" />
                </td>
            </tr>
            <tr id="tr2">
                <td id="tr2td1" class="orangeborder">Last Name</td>
                <td id="tr2td2" class="orangeborder">
                   <input type="text" name="lastName">
                </td>
            </tr>
            <tr>
                <td>Pay Grade</td>
                <td>
                    <input type="text" name="payGrade"
                </td>
            </tr>
            <tr>
                <td>Date of Hire</td>
                <td>
                    <input type="date" name="dateHire"
                </td>
            </tr>
            <tr>
                <td>Date of Termination</td>
                <td>
                    <input type="date" name="dateTerm"
                </td>
            </tr>
            <tr>
                <td>Comments:</td>
                <td colspan="2">
                    <textarea name="comments" rows ="4" cols="25">
                    </textarea>
                </td>
            </tr>
            <tr>
                <td>
                    Marital Status
                </td>
                <td>
                    <input type="radio" name="marital" value="single" />Single<br />
                    <input type="radio" name="marital" value="married" />Married<br />
                    <input type="radio" name="marital" value="divorced" />Divorced<br />
                    <input type="radio" name="marital" value="other" />Other<br />
                </td>
            </tr>
            <tr>
                <td>
                    Pay Grade:
                </td>
                <td>
                    <select name="grade">
                        <option value="admin">Admin</option>
                        <option value="admin2">Admin 2</option>
                        <option value="admin3">Admin 3</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    Terminate Employee: <input type="checkbox" name="chkTerm" value="term" />
                </td>               
            </tr>
          </tbody>
        </table>
        </div>
            <center><input type="submit" value="Submit Form" /></center>
    </form>
   </div>
</body>
</html>
