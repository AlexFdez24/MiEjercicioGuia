#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr));// Inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	// Asocia el socket a cualquiera de las IP de la maquina 
	// htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// Escucharemos en el port 9080
	serv_adr.sin_port = htons(9110);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	// La cola de peticiones pendientes no podra ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	int i;
	// Bucle infinito
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi�n\n");
		// sock_conn es el socket que usaremos para este cliente
		
		// Bucle de atenci�n al cliente
		int terminar = 0;
		while (terminar ==0)
		{
		
			// Ahora recibimos su peticion
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibida una petici�n\n");
			// Tenemos que a�adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			
			// Escribimos la peticion en la consola
			
			printf ("La petici�n es: %s\n",peticion);
			char *p = strtok(peticion, "/");
			int codigo =  atoi (p);
			
			char nombre[20];
			
			if (codigo !=0)
			{
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			}
			
			if (codigo ==0)
				terminar=1;
			else if (codigo ==1) // Piden la longitud del nombre
				sprintf (respuesta,"%d",strlen (nombre));
			else if (codigo ==2) // Quieren saber si el nombre es bonito
				if((nombre[0]=='M') || (nombre[0]=='S'))
				strcpy (respuesta,"SI");
				else
					strcpy (respuesta,"NO");
			
			else if (codigo ==3) // Decir si es alto/a
			{
				p = strtok(NULL, "/");
				float altura =  atof (p);
				if (altura > 1.70)
					sprintf (respuesta, "%s: eres alto/a", nombre);
				else
					sprintf (respuesta, "%s: eres bajo/a", nombre);
			}
			
			else if (codigo == 4) // Comprobar si el nombre es un pali�ndromo
			{	
				int len = strlen(nombre);
				int palindromo = 1;
				for (i = 0; i < len / 2; i++) {
					if (tolower(nombre[i]) != tolower(nombre[len - i - 1])) {
						palindromo = 0;
						break;
					}
				}
				if (palindromo)
					sprintf (respuesta, "%s: es un palindromo", nombre);
				else
					sprintf (respuesta, "%s: no es un palindromo", nombre);
			}
			
			else if (codigo == 5) // Devolver el nombre en may�sculas
			{
				for (i = 0; nombre[i]; i++) {
					nombre[i] = toupper(nombre[i]);
				}
				strcpy(respuesta, nombre);
			}
			
			
			if (codigo !=0)
			{	
				printf ("Respuesta: %s\n", respuesta);
				// Enviamos la respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
		}
		// Se acabo el servicio para este cliente
		close(sock_conn); 
	}
}
