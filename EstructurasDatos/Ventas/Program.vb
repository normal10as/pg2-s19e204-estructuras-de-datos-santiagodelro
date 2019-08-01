Imports System

Module Ventas
    Sub Main(args As String())
        Productos
    End Sub
    Sub Productos()
        Dim Productos = New Object(3, 2) {{1, "CocaCola", 45}, {2, "Pepsi", 40},
            {3, "PasoDeLosToros", 60}, {4, "ToroViejo", 50}}
        Dim CodigoProducto, Cantidad, Total As Int16
        CodigoProducto = 1
        While CodigoProducto <> 0
            Console.Write("Ingrese el codigo de Producto: ")
            CodigoProducto = Console.ReadLine()
            Cantidad = 0
            For r = 0 To 4 - 1
                If CodigoProducto = Productos(r, 0) Then
                    Console.Write(" Descripcion: " & Productos(r, 1) & " Precio: " & Productos(r, 2) & vbLf)
                    Console.Write("Ingrese la Cantidad: ")
                    Cantidad = Console.ReadLine()
                    Console.WriteLine("SubTotal: " & Cantidad * Productos(r, 2))
                    Total += Cantidad * Productos(r, 2)
                End If

            Next
            If Cantidad = 0 Then
                Console.WriteLine("Codigo de producto no existe!")
            End If

        End While
        Console.WriteLine("Total: $" & Total)

    End Sub
End Module

'4.2. Crear un proyecto llamado “Ventas” y un módulo que cuenta con tres vectores cargados
'programáticamente referente a productos: el primero tiene el código, el segundo el nombre y
'el tercero el precio unitario.
' • Repetitivamente se ingresa un código de producto y el programa muestra su descripción
'y precio, si el código no existe mostrar un mensaje de Error.
' • Luego el usuario ingresa la cantidad con lo que el programa responde calculando el total
'de venta por ese producto y el total general (acumulado los productos anteriores).
' • Se repite el proceso hasta que el código sea cero.