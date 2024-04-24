bool verificator = true ;

while ( verificator == true){
    Console.WriteLine("Bienvenido a la Calculadora de fisica MRU y MRUA!");
    Console.WriteLine("!Ojo los resultados se arrojan en km/hrs!");
;

    bool init = true; 

    while (init == true){
        Console.WriteLine("¿Que desea calcular?");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("1. >>>>>>>> Calcular el MRU\n2. >>>>>>>> Calcular el MRUA");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Seleccione un mumero ! ");

        int decision = int.Parse(Console.ReadLine());

        if(decision ==  1){

            bool decision_1_decision = true; 

            while (decision_1_decision == true){

                Console.WriteLine("Calcularemos el MRU !");
                Console.WriteLine("Que desea calcular? ");
                Console.WriteLine("Ingrese el numero del parametro que desea calcular");
                Console.WriteLine("1.- distancia,   2.-velocidad   3.- Tiempo ");

                int decide = int.Parse(Console.ReadLine());

                if (decide == 1){
                    
                    Console.WriteLine("Calculemos la distancia!");
                    Console.WriteLine("Ingrese la velocidad(ojo se calcula en km/h) Solo ingrese el numero...");
                    int vel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tiempo (en minutos) ignore los segundos.");
                    float tiempo = Convert.ToSingle(Console.ReadLine()) / 60;
                    float result = vel * tiempo; 

                    Console.WriteLine($"El resultado es {result}Km");

                }else if (decide == 2){

                    Console.WriteLine("Calculemos la velocidad!");
                    Console.WriteLine("Ingrese la distancia (ojo se calcula en metros) Solo ingrese el numero ...");
                    int dis = int.Parse(Console.ReadLine())/1000;
                    Console.WriteLine("Ingrese el tiempo (en minutos) ignore los segundos.");
                    float tiempo = Convert.ToSingle(Console.ReadLine()) / 60;
                    float result = dis / tiempo; 

                    Console.WriteLine($"El resultado es {result}Km/h");


                }else if(decide == 3){

                    Console.WriteLine("Calculemos el tiempo!");
                    Console.WriteLine("Ingrese la distancia (ojo se calcula en metros) Solo ingrese el numero ...");
                    int dis = int.Parse(Console.ReadLine())/1000;
                    Console.WriteLine("Ingrese la velocidad(ojo se calcula en km/h) Solo ingrese el numero...");
                    int vel = int.Parse(Console.ReadLine());
                    float result = (dis  / (float)vel) * 60 ; 

                    Console.WriteLine($"El resultado es {result}minutos");


                }else{
                    Console.WriteLine("Ingrese Numeros dentro del parametro indicado!\nSeleccione 1 en las siguiente pregunta para volver a usar la calculadora");
                }

                Console.WriteLine("Quiere volver a calcular el MRU?");
                Console.WriteLine("---------------------------");
                Console.WriteLine("");
                Console.WriteLine("1.- SI  // 2.-NO ");
                Console.WriteLine("");
                Console.WriteLine("---------------------------");
                Console.WriteLine(" Ingrese el numero! ");
                int i_1  = int.Parse(Console.ReadLine());
                if ( i_1 == 1  ){
                    decision_1_decision = true; 
                }else if (i_1 == 2 ){
                    decision_1_decision = false; 
                }

            }   //Fin del while de calcular MRU

            init = false;

        } else if ( decision == 2 ){

            bool decision_2_decision = true; 
            double result; 

            while (decision_2_decision == true){

                Console.WriteLine ("Vamos a calcular el MRUA!");
                Console.WriteLine("Que desea calcular?? ");
                Console.WriteLine("1.- La posicion final \n2.- La velocidad final \n3.- Calcular el timepo");
                int decide_2 = int.Parse(Console.ReadLine());
                
                if(decide_2 == 1 ){
                    Console.WriteLine("Vamos a calcular la posicion final!");
                    Console.WriteLine("Ingrese la posicion inicial // en metros");
                    int x0 = int.Parse(Console.ReadLine())/1000;
                    Console.WriteLine("ingrese la velocidad inicial( ojo en km/h) solo ingrese el numero");
                    int v0 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tiempo( ojo en minutos) solo ingrese el numero");
                    int t = int.Parse(Console.ReadLine())/ 60; 
                    Console.WriteLine("Ingrese la aceleracion (Ojo se trabaja en km/h)solo ingrese el numero");
                    int a = int.Parse(Console.ReadLine());
                    result  = x0 + v0 * t + 0.5 * a * (t*t);
                    Console.WriteLine($" El resultado es: {result}Km");
                     
                }else if ( decide_2 == 2){
                    Console.WriteLine("Vamos a calcular la velocidad final! ");
                    Console.WriteLine("Ingres la velocidad inicial ( ojo en km/h) solo ingrese el numero");
                    int v0 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la aceleracion (Ojo se trabaja en km/h)solo ingrese el numero");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tiempo( ojo en minutos) solo ingrese el numero");
                    int t = int.Parse(Console.ReadLine())/ 60;
                    result  = v0 + a * t;
                    Console.WriteLine($"La velocidad final es: {result}km/h"); 

                }else if ( decide_2 == 3){
                    Console.WriteLine("Vamos a calcular el tiempo!");
                    Console.WriteLine("Ingrese la velocidad inicial (ojo en km/h)solo ingrese el numero");
                    int v0 = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Ahora ingrese la velocidad final ( ojo en km/h) Solo ingrese el numero");
                    int v  = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la aceleracion (ojo se trabaja en km/h)solo ingrese el numero");
                    int a = int.Parse(Console.ReadLine());
                    result = (v - v0)/ a; 
                    Console.WriteLine($"El tiempo es:{result}hrs");

                }else{
                    Console
                    .WriteLine("Ingrese Numeros dentro del parametro indicado!\n Seleccione 1 en las siguiente pregunta para volver a usar la calculadora");
                }

                Console.WriteLine("Quiere volver a calcular el MRUA?");
                Console.WriteLine("---------------------------");
                Console.WriteLine("");
                Console.WriteLine("1. >>>>>>> SI\n2. >>>>>>>> NO ");
                Console.WriteLine("");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Ingrese el numero! ");
                int i_2  = int.Parse(Console.ReadLine());
                if ( i_2 == 1  ){
                    decision_2_decision = true; 
                }else if (i_2 == 2 ){
                    decision_2_decision = false; 
                }

            
            } //fin del while de calcular el MRUA 

            init = false;

        } else{
            Console.WriteLine("Selecione un numero entre 1 y 2");
        }

    }

    bool init_2  =  true; 
    
    while(init_2 == true){

        Console.WriteLine(" Desea volver a usar la caluladora?");
        Console.WriteLine("---------------------------");
        Console.WriteLine("");
        Console.WriteLine("1. >>>>>>> Si\n2. >>>>>> No");
        Console.WriteLine("");
        Console.WriteLine("---------------------------");
        Console.WriteLine(" Selecione un numero");
        int start_again = int.Parse(Console.ReadLine());

        if(start_again == 1){
            init_2 = false;
        }else if (start_again == 2){
            init_2 = false; 
            verificator = false;
        }else {
            Console. WriteLine("Ingreso valores fuera del rango especificado, (ingrese numeros entre 1 y 2 !)");
        }   

    } //fin del while secundario >> este decide si volver a usar la calculadora o no.

} // fin del while principal!

