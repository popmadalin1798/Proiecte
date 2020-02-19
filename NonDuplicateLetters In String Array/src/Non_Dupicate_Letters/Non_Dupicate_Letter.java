/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Non_Dupicate_Letters;

import java.util.Map;
import java.util.Set;
import java.util.TreeMap;
import java.util.TreeSet;

/**
 *
 * @author Pop Madalin-Emilian
 */
public class Non_Dupicate_Letter {
    //function that returns a list of the letters that don't repet in a string array.Time complexity=N+N;
    public Set<String> NDL(String [] array)
    {
        Map<String,Integer> letters=new TreeMap<>();//map that has as keys the letters and as value the number of appereances in the array
        Set<String> one_letter=new TreeSet<>();//set that retains the letters that don't repeat
        for(int i=0;i<array.length;i++)//for loop for going thorugh the array
        {
            int n=0;//counter for the number of apperances
            if(letters.containsKey(array[i]))//we verify if the letter is already a key in the map 
            {
                n++;//we increment with 1 the counter
            }
            letters.put(array[i], n+1);//we put the key and the value in map
        }
        letters.forEach((k,v)->{//foreach loop going thorugh the keys and values of the map
            if(v==1)//if the value of the key is equal to 1
            {
                one_letter.add(k);//we add the key(letter) to the set
            }
        });
        return one_letter;//return the list of letters that don't repeat in the string
    }
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Non_Dupicate_Letter ND=new Non_Dupicate_Letter();//we initialize our class with the default constructor
        String[] array={"a","a","b","c","c","d"};//exemple of string array that contains as letters that don't repeat b and d
        System.out.println(ND.NDL(array));//print the letter that don't repeat with our function NDL from the class ND.As argument we have our exemple string array
        
    }
    
}
