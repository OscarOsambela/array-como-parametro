using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int[] calificaciones = new int[]{ 11,10,13,9,14,11,};
    double promedioResultado = ObtenerPromedio(calificaciones);
    int n = 1;
    foreach(int nota in calificaciones){
      Console.WriteLine("{0} Nota.- {1}",n,nota);
      n++;
    }
    Console.WriteLine("El promedio es: {0}", promedioResultado);
    
  }

static double ObtenerPromedio(int [] arrayPuntajes){
  int cantidad = arrayPuntajes.Length;
  double promedio;
  int suma = 0;

  for(int i = 0; i < cantidad; i++){
    suma += arrayPuntajes[i];
  }
  promedio = (double)suma / cantidad;
  return promedio;
}
}