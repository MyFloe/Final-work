# Итоги блока. Выбор специализации. IT-специалист

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.


## Задание:

1. Создать репозиторий на GitHub  
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)  
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)  
4. Написать программу, решающую поставленную задачу  
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)  
 

## Решение:

**1. Создать репозиторий на GitHub** 

--->
https://github.com/MyFloe/Final-work
 

**2. Нарисовать блок-схему алгоритма**

--->
https://github.com/MyFloe/Final-work/blob/main/Схема.png
 

**3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)**

--->
https://github.com/MyFloe/Final-work/blob/main/README.md

**4. Написать программу, решающую поставленную задачу**  

*Задача:*

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Описание Решения:**

**_Строку преобразуем в массив с разделителем элементов "," при помощи оператора Split.
Далее проверяем каждый элемент массива подходит ли он под указанное условие. А именно длина элемента должна быть меньше или равна 3.
Если условие удовлетворяет, элемент записывается в новый массив и переходим к следующемы индексу массива. (i+1). Если условие не удовлетворяется, то сразу переходим к проверки следующий индекс. И так до тех пор пока не пройдем весь массив. Как весь массив будет пройден на экран выведется новый массив с индексами меньше или равными 3._**

**https://github.com/MyFloe/Final-work/blob/main/Program.cs**


**5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)**
  
Список коммитов:
1. добавлен файл readme.
2. Добавлена схема и ссылки в readme.
3. Добавлен Program.cs изменения в readme.
