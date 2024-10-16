#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>

void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	// int socket_conn = * (int *) socket;
	
	char peticion[512];
	char respuesta[512];
	int ret;
	
	// Bucle de atenci�n al cliente
	int terminar = 0;
	while (terminar ==0)
	{
		memset(peticion, 0, sizeof(peticion));
		memset(respuesta, 0, sizeof(respuesta));
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
		
		float parametro;
		
		if (codigo !=0)
		{
			p = strtok( NULL, "/");
			parametro = atof (p);
			printf ("Codigo: %d, Par�metro: %.2f\n", codigo, parametro);
		}
		
		if (codigo ==0)
			terminar=1;
		else if (codigo ==1) { // Conversi�n a Fahrenheit
			float fahrenheit = (parametro * 9.0 / 5.0) + 32;
			sprintf (respuesta, "%.2f", fahrenheit);
		}
		
		else if (codigo ==2) { // Conversi�n a Celsius
			float celsius = (parametro - 32) * 5.0 / 9.0;
			sprintf(respuesta, "%.2f", celsius);
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
	
int main(int argc, char *argv[])
{
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	
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
	// Escucharemos en el port 9110
	serv_adr.sin_port = htons(9110);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	// La cola de peticiones pendientes no podra ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	int i;
	int sockets[100];
	pthread_t thread;
	i = 0;
	// Bucle infinito
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi�n\n");
		
		sockets[i] = sock_conn;
		// sock_conn es el socket que usaremos para este cliente
		
		// Crear thread y decirle lo que tiene que hacer
		pthread_create (&thread, NULL, AtenderCliente, &sockets[i]);
		i = i+1;
	}
}
