Algoritmo Ejercicio3
	Definir sector,cantidad, precio, total Como Real
	Escribir "1 Palco"
	Escribir "2 Tribuna"
	Escribir "3 Preferencia"
	Escribir "4 General"
	Leer sector
	
	Escribir "Cantidad de entradas:"
	Leer cantidad
	
	Segun sector Hacer
		1:
			precio=300
		2:
			precio=125
		3:
			precio=75
		4:
			precio=50
		De Otro Modo:
			Escribir "Opcion invalida"
	Fin Segun
	total=precio*cantidad
	Escribir "Total a pagar", total
	
FinAlgoritmo
