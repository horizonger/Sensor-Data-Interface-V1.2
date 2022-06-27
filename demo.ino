
// demo ardunio code
String A;
void setup (void) {

   Serial.begin(9600);

   Serial.println("Arduino for loop");
   for (int i=0; i<10; i++) 
   A=i;
   Serial.println(A);
}

void loop(void) {
}
