#include <stdio.h>

int main(){
	
// kullanc�dan dik kenar uzunlu�u al�nan ve hipoten�s hesaplayan program

float kenar1,kenar2;
printf("Birinci kenar uzunlugunu giriniz: ");
scanf("%f", &kenar1);
printf("Ikinci kenar uzunlugunu giriniz: ");
scanf("%f", &kenar2);
float toplam= pow(kenar1,2)+pow(kenar2,2);
float hipotenus= sqrt(toplam);
printf("Ucgenin hipotenusu: %.2f", hipotenus);

}
