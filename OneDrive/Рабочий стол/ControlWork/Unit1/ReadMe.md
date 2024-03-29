# Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам #

1. Выводится приветственное сообщение с запросом ввода элементов массива.

2. Вводимая строка разделяется на элементы массива с использованием метода *Split*, и результат сохраняется в массиве *inputArray*.

3. Вызывается метод *FilterArray* с аргументом *inputArray*, чтобы отфильтровать массив и получить новый массив с отфильтрованными элементами, который сохраняется в массиве *resultArray*.

4. Выводится сообщение *"Результат:"*.

5. Через цикл *foreach* перебираются элементы массива *resultArray*, и каждый элемент выводится на экран.

## Метод *FilterArray* принимает массив *array* в качестве аргумента и возвращает массив с отфильтрованными элементами. Он работает следующим образом: ##

1. Инициализируется переменная *newLength* с начальным значением *0* для подсчета количества элементов, удовлетворяющих условию.

2. Через цикл *for* перебираются элементы массива *array*.

3. Проверяется длина каждого элемента. Если длина элемента меньше или равна *3 символам*, инкрементируется переменная *newLength*.

4. Создается новый массив *filteredArray* с размером *newLength* для хранения отфильтрованных элементов.

5. Инициализируется переменная *index* с начальным значением *0* для индексации элементов нового массива *filteredArray*.

6. Через цикл *for* перебираются элементы массива array.

7. Проверяется длина каждого элемента. Если длина элемента меньше или равна 3 символам, элемент добавляется в массив *filteredArray* на позицию *index*, а затем инкрементируется переменная *index*.

8. Возвращается массив *filteredArray* с отфильтрованными элементами.

## Таким образом, программа фильтрует исходный массив по длине элементов, оставляя только те, у которых длина меньше или равна 3 символам, и выводит результат на экран. ##

# Прилагается блок-схема к задаче #

1. <image src="C:\Users\manof\OneDrive\Рабочий стол\ControlWork\Unit1\Диаграмма к контрольной.jpg" alt="блок-схема к задаче">

