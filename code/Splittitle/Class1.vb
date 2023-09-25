Imports System.Text

Public Class LCDSmartie


    Public Function function1(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Errhand
        If param1 = "about" And param2 = "function" Then
            Return "  Splits winamp track title and returns the 1st part"

        Else

            Dim Parts = Split(param1, "-")
            Return Trim(Parts(0))


        End If

Errhand:
        Return ""
    End Function

    Public Function function2(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Errhand
        If param1 = "about" And param2 = "function" Then
            Return "  Splits winamp track title and returns the 2nd part"

        Else

            Dim Parts = Split(param1, "-")
            Return Trim(Parts(1))


        End If

Errhand:
        Return ""



    End Function

    Public Function function3(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Errhand
        If param1 = "about" And param2 = "function" Then
            Return "  Splits winamp track title and returns the 3rd part"

        Else

            Dim Parts = Split(param1, "-")
            Return Trim(Parts(2))


        End If

Errhand:
        Return ""


    End Function

    Public Function function4(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Errhand
        If param1 = "about" And param2 = "function" Then
            Return "  Splits winamp track title and returns 4th part"

        Else

            Dim Parts = Split(param1, "-")
            Return Trim(Parts(3))


        End If

Errhand:
        Return ""


    End Function
    Public Function function5(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Errhand
        If param1 = "about" And param2 = "function" Then
            Return "  Splits winamp track title and returns 5th part"

        Else

            Dim Parts = Split(param1, "-")
            Return Trim(Parts(4))


        End If
Errhand:
        Return ""



    End Function




    Public Function function11(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Errhand
        If param1 = "about" And param2 = "function" Then
            Return "  Using custom delimiter. Splits winamp track title and returns the 1st part"

        Else

            Dim Parts = Split(param1, param2)
            Return Trim(Parts(0))


        End If

Errhand:
        Return ""

    End Function

    Public Function function12(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Errhand
        If param1 = "about" And param2 = "function" Then
            Return "  Using custom delimiter. Splits winamp track title and returns the 2nd part"

        Else

            Dim Parts = Split(param1, param2)
            Return Trim(Parts(1))


        End If



Errhand:
        Return ""

    End Function

    Public Function function13(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Errhand
        If param1 = "about" And param2 = "function" Then
            Return "  Using custom delimiter. Splits winamp track title and returns the 3rd part"

        Else

            Dim Parts = Split(param1, param2)
            Return Trim(Parts(2))


        End If

Errhand:
        Return ""


    End Function

    Public Function function14(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo Errhand
        If param1 = "about" And param2 = "function" Then
            Return "  Using custom delimiter. Splits winamp track title and returns 4th part"

        Else

            Dim Parts = Split(param1, param2)
            Return Trim(Parts(3))


        End If

Errhand:
        Return ""


    End Function
    Public Function function15(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" And param2 = "function" Then
            Return "  Using custom delimiter. Splits winamp track title and returns 5th part"

        Else

            Dim Parts = Split(param1, param2)
            Return Trim(Parts(3))


        End If

Errhand:
        Return ""


    End Function



    Public Function function20(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" Or param2 = "function" Then
            Return " Developer:Nikos Georgousis"

        Else
            Return " splititle.dll version 2.1 by limbo"

        End If

    End Function

    Public Function SmartieDemo()
        Dim demolist As New StringBuilder()

        demolist.AppendLine("splittitle plugin for LCD Smartie")
        demolist.AppendLine("This pluging splits title taken from winamp or any other player and returns on;y on e part like Artist, Track etc")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function1 ------")
        demolist.AppendLine(">>>  Splits winamp track title and returns the 1st part  <<<")
        demolist.AppendLine("Get the first part by splitting parameter 1 on '-' :  $dll(splittitle,1,$WinampTitle, )")
        demolist.AppendLine("------ Function2 ------")
        demolist.AppendLine(">>>   Splits winamp track title and returns the 2nd part  <<<")
        demolist.AppendLine("Get the second part by splitting parameter 1 on '-' :  $dll(splittitle,2,$WinampTitle, )")
        demolist.AppendLine("------ Function3 ------")
        demolist.AppendLine(">>>   Splits winamp track title and returns the 3rd part  <<<")
        demolist.AppendLine("Get the third part by splitting parameter 1 on '-' :  $dll(splittitle,3,$WinampTitle, )")
        demolist.AppendLine("------ Function4 ------")
        demolist.AppendLine(">>>  Splits winamp track title and returns 4th part  <<<")
        demolist.AppendLine("Get the fourth part by splitting parameter 1 on '-' :  $dll(splittitle,4,$WinampTitle, )")
        demolist.AppendLine("------ Function5 ------")
        demolist.AppendLine(">>>  Splits winamp track title and returns 5th part  <<<")
        demolist.AppendLine("Get the fifth part by splitting parameter 1 on '-' :  $dll(splittitle,5,$WinampTitle, )")
        demolist.AppendLine("------ Function11 ------")
        demolist.AppendLine(">>>  Using custom delimiter. Splits winamp track title and returns the 1st part  <<<")
        demolist.AppendLine("Get the first part by splitting parameter 1 on parameter2 :  $dll(splittitle,11,Test text * Hello World,*)")
        demolist.AppendLine("------ Function12 ------")
        demolist.AppendLine(">>>  Using custom delimiter. Splits winamp track title and returns the 2nd part  <<<")
        demolist.AppendLine("Get the first part by splitting parameter 1 on parameter2 :  $dll(splittitle,12,Test text * Hello World,*)")
        demolist.AppendLine("------ Function13 ------")
        demolist.AppendLine(">>>  Using custom delimiter. Splits winamp track title and returns the 3rd part <<<")
        demolist.AppendLine("Get the first part by splitting parameter 1 on parameter2 :  $dll(splittitle,13,Test text/Hello/This is what you get,/)")
        demolist.AppendLine("------ Function14 ------")
        demolist.AppendLine(">>>  Using custom delimiter. Splits winamp track title and returns 4th part  <<<")
        demolist.AppendLine("Get the first part by splitting parameter 1 on parameter2 :  $dll(splittitle,13,Hi!Hello!Wow!Q!Next!Another,!)")
        demolist.AppendLine("------ Function15 ------")
        demolist.AppendLine(">>>  Using custom delimiter. Splits winamp track title and returns 5th part  <<<")
        demolist.AppendLine("Get the fifth part by splitting parameter 1 on parameter2 :  $dll(splittitle,15,$WinampTitle, - )")
        demolist.AppendLine("------------------------------------------------------------------------------------------------------------------")
        demolist.AppendLine("")
        demolist.AppendLine(" *** Visit ***")
        demolist.AppendLine("> Home page")
        demolist.AppendLine("https://lcdsmartie.sourceforge.net")
        demolist.AppendLine("> Forums")
        demolist.AppendLine("https://www.lcdsmartie.org")
        demolist.AppendLine("> Active development branch (latest version)")
        demolist.AppendLine("https://github.com/stokie-ant/lcdsmartie-laz")
        demolist.AppendLine("")
        demolist.AppendLine("")
        demolist.AppendLine("")

        Dim result As String = demolist.ToString()
        Return result
    End Function

    Public Function SmartieInfo()
        Return "Developer:Nikos Georgousis (limbo)" & vbNewLine & "Version:2.1"
    End Function


End Class
