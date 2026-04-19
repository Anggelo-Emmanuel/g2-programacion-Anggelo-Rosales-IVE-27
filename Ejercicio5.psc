Algoritmo Ejercicio5
	Definir cantidad, opcion Como Entero
	Definir precio, total, descuento, pagar Como Real
	
	precio=650 * 1.12
	
	Escribir "Cantidad:"
	Leer cantidad
	
	Escribir "1 Efectivo"
	Escribir "2 Tarjeta"
	Escribir "3 Vale"
	Leer opcion
	
	total <- precio * cantidad
	
	Segun opcion Hacer
		1:
			descuento=total * 0.10
		2:
			descuento=total * 0.05
		3:
			descuento=Total * 0.15
		De Otro Modo:
			descuento=0
	FinSegun
	
	pagar <- total - descuento
	
	Escribir "Total sin descuento: ", total
	Escribir "Descuento: ", descuento
	Escribir "Total a pagar: ", pagar
	
FinAlgoritmo
