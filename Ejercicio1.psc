Algoritmo Ejercicio1
	Definir angulo, opcion Como Real
	
	Escribir "Ingrese el angulo en grados:"
	Leer angulo
	
	Escribir "1. Seno"
	Escribir "2. Coseno"
	Escribir "3. Tangente"
	Leer opcion
	
	Segun opcion Hacer
		1:
			Escribir "Seno: ", Sen(angulo)
		2:
			Escribir "Coseno: ", Cos(angulo)
		3:
			Escribir "Tangente: ", Tan(angulo)
		De Otro Modo:
			Escribir "Opcion invalida"
	FinSegun
	
FinAlgoritmo
