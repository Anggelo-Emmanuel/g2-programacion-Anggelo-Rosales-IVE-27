Algoritmo Ejercicio4
	Definir opcion, valor Como Real
	Escribir "1: Metros a pies"
	Escribir "2: Metros a centimetros"
	Escribir "3: Metros a pulgadas"
	Leer opcion
	
	Escribir "Ingrese el valor en metros: "
	Leer valor
	Segun opcion Hacer
		1:
			Escribir valor*3.28084
		2:
			Escribir  valor*100
		3:
			Escribir valor*39.3701
		De Otro Modo:
			Escribir "Opcion no valida"
	Fin Segun
	
	
FinAlgoritmo
