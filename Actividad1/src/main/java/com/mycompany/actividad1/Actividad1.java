package com.mycompany.actividad1;

import javax.swing.JOptionPane;

public class Actividad1 {

    public static void main(String[] args) {
     // JOptionPane.showMessageDialog(null, "Hola mundo");
        String name = JOptionPane.showInputDialog("What's your name?");
        System.out.println(name);
        
        int WARNING_MESSAGE = JOptionPane.WARNING_MESSAGE;
    }
}
