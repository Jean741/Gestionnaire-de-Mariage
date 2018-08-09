Imports System.Xml

Module module_config


    Public Function GetChaineConnectFromXML() As String
        Dim chaine As String = ""
        Dim nombase As String = ""
        Dim host As String = ""
        Dim login As String = ""
        Dim psw As String = ""
        Dim hostEX As String = ""
        Dim nombaseEX As String = ""
        Dim Menu As String = ""
        Dim XmlDoc As New XmlDocument()
        XmlDoc.Load(Application.StartupPath & "\bases_config.xml")

        Dim element As XmlNodeList
        element = XmlDoc.DocumentElement.GetElementsByTagName("base")

        Dim noeud, noeudEnf As XmlNode
        For Each noeud In element
            If noeud.Attributes.Item(0).Value.ToString.Equals("True") Then

                For Each noeudEnf In noeud.ChildNodes


                    If noeudEnf.LocalName = "nom" Then
                        nombase = noeudEnf.InnerText
                        nombaseEX = noeudEnf.InnerText
                    End If
                    If noeudEnf.LocalName = "host" Then
                        host = noeudEnf.InnerText
                        hostEX = noeudEnf.InnerText
                    End If
                    If noeudEnf.LocalName = "login" Then
                        login = noeudEnf.InnerText
                    End If
                    If noeudEnf.LocalName = "psw" Then
                        psw = noeudEnf.InnerText
                    End If
                    If noeudEnf.LocalName = "menu" Then
                        Menu = noeudEnf.InnerText
                    End If
                Next
            End If
        Next

        chaine = "Data Source=" + host + ";Initial Catalog=" + nombase + ";Connect Timeout=500000;Integrated Security=True"

        GetChaineConnectFromXML = chaine
    End Function
End Module
