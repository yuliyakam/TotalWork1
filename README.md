# Описание программы 
## Задача
Программа, из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Массив можно ввести с клавитуры, либо задать на старте выполнения алгоритма. При решении лучше использовать массивы, а не коллекции.
## Решение
1. Создаем методы для программы
2. В методе **ReadData** программа запрашивает длинну массива у пользователя
3. В методе **GenArray** пользователь вводит элементы строкового массива. Т.о. формируется массив, из которого в дальнейщем будет произведена выборка по критериям.
4. Метод **ResultArray** принимает на вход массив, заполненный пользователем, проводит в нем отбор элементов, удовлетворяющих условию задачи(длина меньше или равна 3символам). Формирует из этих элементов через запятую строку. При помощи *TrimEnd* убираем последнюю запятую в строке. Делим ее на части *Split* метедом по запятым и преобразуем в массив. Он является результирующим. 
5. Метод **PrintArray** выводит одномерный массив в консоль \
*Примечание* Наглядно работу метода **ResultArray** можно увидеть на блок схеме: 
![Герб Крыма](scheme1.jpg "Emblem")aA