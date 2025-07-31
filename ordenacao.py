import random

class Util:
    
    
    
    
    
    @staticmethod
    def popular_aleatorio_numeros(lista, quantidade, inicio, fim):
        for _ in range(quantidade):
            lista.append(random.randrange(inicio, fim))    
            
            
    @staticmethod
    def exibir_lista_numeros(lista):
        """_summary_
            exibe uma lista de inteiros
        Args:
            contem uma lista de inteiros
        """
        for item in lista:
            print(item)
            
    @staticmethod
    def popular_aleatorio_palavras(lista, quantidade, tamanho):
        letras = "abcdefghijklmnopqrstuvwxyz"
        for _ in range(quantidade):
            palavra_gerada = ""
            letras_sorteada = ""
            for i in range(tamanho):
                letra_sorteada = letras[random.randrange(len(letras))]
                palavra_gerada += letra_sorteada
                
        lista.append(palavra_gerada)

      
        
        from util import Util

        lista_numeros = []
        lista2_numeros = []
        
        lista_palavras = []
        
        Util.popular_aleatorio_numeros(lista_numeros, 10, 100, 500)
        Util.exibir_lista_numeros(lista_numeros)
        
        lista2_numeros.extend(lista_numeros)
        
        Util.popular_aleatorio_palavras(lista_palavras, 10, 6)
        Util.exibir_lista_palavras(lista_palavras)


    



