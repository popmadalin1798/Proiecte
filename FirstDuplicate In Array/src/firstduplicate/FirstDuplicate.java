/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package firstduplicate;

import java.util.Set;
import java.util.TreeSet;

/**
 *
 * @author popma
 */
public class FirstDuplicate {
   //function that returns the number of first duplicate in an array
    /**
     * @param args the command line arguments
     */
     public int FD(int [] array)
    {
        Set<Integer> unique=new TreeSet<>();
        for(int i=0;i<array.length;i++)
        {
            if(unique.contains(array[i]))
            {
                return array[i];
            }
            else
            {
                unique.add(array[i]);
            }
        }
        return -1;
    }
    public static void main(String[] args) {
        int [] array={1,2,3,1,5,2};
        FirstDuplicate fd=new FirstDuplicate();
        System.out.println("First duplicate has the number:"+fd.FD(array));
    }
    
}
