Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Header() As ActionResult
        ViewData("Message") = "Your application description page."
        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."
        Return View()
    End Function

    Function CoursePlanner() As ActionResult
        ViewData("Message") = "This is your course planner message."
        Return View()
    End Function
End Class
