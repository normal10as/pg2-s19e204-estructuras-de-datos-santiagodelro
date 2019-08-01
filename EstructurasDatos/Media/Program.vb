Imports System

Module Media
    Sub Main(args As String())
        Arreglo()
    End Sub
    Sub Arreglo()
        Dim Lista(4) As Integer
        Dim Numero, r, Media, Promedio, c As Integer
        c = 5
        For r = 0 To 5 - 1
            Console.Write("Ingrese {0} valor: ", c)
            c -= 1
            Numero = Console.ReadLine()
            Lista(r) = Numero
            Media += Lista(r)
        Next
        Promedio = Media / 5
        Console.WriteLine("La Media es: " & Promedio)

        For r = 0 To 5 - 1

            Console.WriteLine("Posicion {0} del Elemento " & Lista(r), r & " La Desviacion es: " & Lista(r) - Promedio)

        Next






    End Sub
End Module

'4.1. Crear un proyecto llamado “Media” y un módulo que permita cargar 5 números en un
'arreglo de 5 elementos; calcular la media y luego imprimir cada elemento del arreglo y la
'desviación que tiene respecto a la media. La MEDIA se obtiene la sumatoria de los todos
'elementos del arreglo y se divide por la cantidad de estos. La DESVIACION de cada
'elemento se obtiene restándole al elemento la MEDIA.