package Exam;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;


public class Menu {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        int choose =0 ;
        List<Student> list = new ArrayList<>();
        do{
            System.out.println("1. Add student records");
            System.out.println("2. Display student records");
            System.out.println("3. Save");
            System.out.println("4. Exit");
            System.out.print("Choose : ");
            choose = Integer.parseInt(sc.nextLine());
            switch(choose){
                case 1 ->{
                    Student s = new Student();
                    s.input();
                    list.add(s);
                }
                case 2 ->{
                    list.forEach(System.out::println);
                }
                case 3 ->{

                }
                default ->{}
            }
        } while(choose !=4);
    }

}
