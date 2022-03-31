import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);
	    System.out.println("Birinci kenar uzunluğunu giriniz: ");
        float kenar1=scanner.nextFloat();
        System.out.println("İkinci kenar uzunluğunu giriniz: ");
        float kenar2=scanner.nextFloat();
        System.out.println("Hipotenüs: "+Math.sqrt(Math.pow(kenar1,2)+Math.pow(kenar2,2)));
    }
}
