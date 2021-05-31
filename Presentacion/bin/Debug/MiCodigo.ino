//Comentario
//ProgramaDePrueba
//Comentarios
//FuncionParaIniciarElLlenado
//Inicio programa 
int alarma = 1;
int x = 1;
int t = 15*1000;
int agua = 2;
int re = 10000;
void setup() { 
pinMode(alarma,OUTPUT);
pinMode(agua, OUTPUT);
}
 void loop() {
if (x == 1) { 
digitalWrite(agua, 1); 
delay(re); 
digitalWrite(agua, 0); 
delay(1000); 
digitalWrite(alarma, 1); 
delay(t); 
digitalWrite(alarma, 0);
x++; 
}
}
//FinDelPrograma
