Imports System

Module Program
    Sub Main(args As String())
        Dim totalCompra As Double = 0
        Dim totalDescuento As Double = 0

        Console.Write("Ingrese la cantidad de compras que desea realizar: ")
        Dim cantidadCompras As Integer = Integer.Parse(Console.ReadLine())

        If cantidadCompras <= 0 Then
            Console.WriteLine("Cantidad no válida. El programa se ha terminado.")
        Else
            For i As Integer = 1 To cantidadCompras
                Console.Write($"Ingrese el monto de la compra #{i}: ")
                Dim montoCompra As Double = Double.Parse(Console.ReadLine())
                totalCompra += montoCompra ' Acumular el monto de la compra
            Next

            If totalCompra > 1000 Then
                totalDescuento = totalCompra * 0.1 ' 10% de descuento
            ElseIf totalCompra > 500 Then
                totalDescuento = totalCompra * 0.05 ' 5% de descuento
            End If

            totalCompra -= totalDescuento ' Restar el descuento al total de compra

            If totalCompra > 0 Then
                Console.WriteLine($"El total de la compra con descuentos aplicados es: ${totalCompra:F2}")
            Else
                Console.WriteLine("No se realizaron compras.")
            End If

            Console.WriteLine("Creadores: Javier Alexander Naranjo Moz y Francisco Andres Garcia Mena")
        End If
    End Sub
End Module
