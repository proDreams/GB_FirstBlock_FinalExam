# Итоговая проверочная работа

## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:  
> [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]  
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
[“Russia”, “Denmark”, “Kazan”] → []

## Алгоритм решения:
1. Запрашиваем у пользователя ввод элементов массива разделённых запятой и пробелом
2. Разделяем введёную строку на массив с отдельными элементами
3. Вызываем функцию SearchElements передавая в неё подготовленный массив с элементами
4. Создаём пустой массив result
5. В цикле for перебираем элементы массива. 
6. Если размер элемента меньше или равен трём символам:
* Увеличиваем размер массива result на 1
* Помещаем на пустое место в массиве result элемент из исходного массива
7. Если размер элемента больше трёх символов - продолжаем цикл
8. По окончанию цикла - возвращаем из функции массив result
9. Выводим массив в консоль.

