<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
        <script type="text/javascript">

            function contentLoaded() {
                var source = '<%: ViewBag.Message%>';
                //var ul = $("#messages");
                source.onmessage = function (e) {

                    var li = document.createElement("li");
                    var returnedItem = e.data;
                    li.textContent = returnedItem;
                    $("#messages").append(li);
                }
            };

            window.addEventListener("DOMContentLoaded", contentLoaded, false);
        </script>
        <h2><%: ViewBag.Message%></h2>
        <p>
            SSE WITH ASP.NET MVC
        </p>
        <ul id="messages">
        </ul>--%>
    </div>
</body>
</html>





