# Flyweight
## Objetivo
Reduzir a quantidade de objetos em memoria, assim reduz consumo de memoria da aplicação

## Como funciona ?
É dividido em duas partes, Intrínsica, Extrínsica

## Intrínsico
É o que é compartilhado com todos os objetos, não muda, assim ela é compartilhada com todos os objetos

## Extrínsico
É a parte que é mutavel no objeto, pode ser movida para fora e ser passada como parametro

## Quando aplicar ?
1. Aplicação possui grande quantidade de objetos em memoria
2. Possuo custo alto de armazenamento, alto consumo de memoria
3. A maior parte dos objetos por ser extrínsica
4. Muitos grupos de objetos podem ser substituido por poucos
5. A aplicação não depende da identidade dos objetos