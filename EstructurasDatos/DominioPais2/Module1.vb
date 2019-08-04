Module Module1
    Private Coleccion As New Collection

    Sub Main()
        Paises()
        Dim Dom As String
        Do
            Console.Write("Ingrese el dominio('ar' para Argentina: ")
            Dom = Console.ReadLine()
            If Coleccion.Contains(Dom) Then
                Console.WriteLine("Pais: " & Coleccion(Dom))
            End If

        Loop While Dom <> ""
    End Sub
    Sub Paises()
        Coleccion.Add("Argentina", "ar")
        Coleccion.Add("Brasil", "br")
        Coleccion.Add("Uruguay", "uy")
        Coleccion.Add("Australia", "au")
        Coleccion.Add("Bolivia", "bo")
        Coleccion.Add("Francia", "fr")
        Coleccion.Add("España", "es")
        Coleccion.Add("Paraguay", "py")

    End Sub



End Module

'4.4. Crear un proyecto llamado “DominioPais” y un módulo que cargue programáticamente
'nombre de países y su dominio de país en una Collection. A continuación, debe permitir
'realizar consultas: se introduce el nombre del dominio y se deberá mostrar el nombre del
'país.Salir cuando el valor ingresado es vacío.