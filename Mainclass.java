import java.util.*;
public class Mainclass
{
    private String username;
    private String password;
    private String IdNumber;
    
    public Mainclass(String username, String password, String IdNumber){
        this.IdNumber= IdNumber;
        this.username= username;
        this.password= password;
    }

    public static String getIDnumber(String IdNumber){
        return IdNumber;
    }
    public static String getUsername(String username){
        return username;
    }

    public static String getPassword(String password){
        return password;
    }

    public void setIDnumber(String IdNumber){
        this.IdNumber = IdNumber;
    }

    public void setUsername(String username){
        this.username = username;
    }

    public void setPassword(String password){
        this.password =password;
    }
    public String toString(){
        String str;
        str ="your id: "+IdNumber+" username: "+username+" password: "+password;
        return str;
    }

    public static void main(String[] args)
    {
        Mainclass[] s = new Mainclass[5];
        Scanner kb = new Scanner(System.in);
        
       
            for(int i = 0; i<s.length;i++) {
                    System.out.println("enter your Id number: ");
                    String id = kb.nextLine();
                    s[i].setIDnumber(id);

                    System.out.println("enter username: ");
                    String usurname=kb.nextLine();
                    s[i].setUsername(usurname);

                    System.out.println("enter password: ");
                    String pass =kb.nextLine();
                    s[i].setPassword(pass);
            }
   
        System.out.println(s.toString());
        
    }
}