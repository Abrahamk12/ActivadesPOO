package com.mycompany.actividad1;

public class gato implements carro, Rotable{
    public gato(){
        
    }
    
    public void maullar(){
        System.out.println("mia");
    }
    @Override
    public void arrancar() {
        System.out.println("El gato va a arrancar en ");
        for (int i = 3; i > 0; i--) {
            System.out.println(i);
        }
        System.out.println("El gato arranco");
    }

    @Override
    public void frenar() {
        
    }

    @Override
    public void rota(int n) {
        System.out.println("El gato roto "+n+" grados");
    }
    
}
