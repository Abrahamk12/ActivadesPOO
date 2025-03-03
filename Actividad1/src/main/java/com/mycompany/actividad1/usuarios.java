package com.mycompany.actividad1;

public class usuarios {
    String usuarios [][] = new String[3][2];
    String usuarios2 [][] = {
        {"Juan", "123"},
        {"Pepe", "123"}
    };
    private String aUsuarios[] = new String[5];
    public usuarios(){
        
    }
    void imprimeirUsuarios(){
        for (int i = 0; i < usuarios2.length; i++) {
            for (int j = 0; j < usuarios2.length; j++) {
                System.out.println(usuarios2[i][j]);
            }
        }
    }
    public void setAUsuarios(String nombre, int pos){
        this.aUsuarios[pos] = nombre;
    }
    public String getAUsuario(int pos){
        return this.aUsuarios[pos];
    }
}
