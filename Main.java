import java.text.DecimalFormat;
import java.text.Format;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner giris=new Scanner(System.in);
        System.out.print("Matematik notu: ");
        int matematik=giris.nextInt();
        System.out.print("Fizik notu: ");
        int fizik=giris.nextInt();
        System.out.print("Kimya notu: ");
        int kimya=giris.nextInt();
        System.out.print("Türkçe notu: ");
        int turkce=giris.nextInt();
        System.out.print("Tarih notu: ");
        int tarih=giris.nextInt();
        System.out.print("Müzik notu: ");
        int muzik=giris.nextInt();
        int sonuc=matematik+fizik+kimya+turkce+tarih+muzik;
        double ortalama=sonuc/6.0;
        DecimalFormat formatlama=new DecimalFormat("0.##");
        System.out.print("Derslerin not ortalaması: "+formatlama.format(ortalama));
    }
}
