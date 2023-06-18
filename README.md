Завдання:
Розробити технічне завдання. Показати декомпонування завдання, де частина завдань має бути реалізована з використанням породжуючих патернів:
-	Інтерпретатор (Interpreter). 
-	Посередник (Mediator).  

Технічне завдання
Нашому клієнту потрібен додаток для продажу автомобілів на C#, який дозволяє клієнтам фільтрувати автомобілі за маркою, моделлю, роком випуску та ціновим діапазоном.
Ми реалізуємо це за допомогою паттерну Interpreter, де кожен фільтр представлений виразом. Ми також використаємо паттерн Mediator для відстеження фільтрів і сповіщення інтерфейсу користувача про зміну фільтрів. У додатку буде функція кошика, яка дозволить клієнтам додавати і видаляти автомобілі з кошика.

Вимоги:
1.	Інтернет-магазин повинен дозволяти клієнтам переглядати та фільтрувати доступні автомобілі.

2.	Інтернет-магазин повинен дозволяти покупцям додавати та видаляти автомобілі з кошика.

3.	Інтернет-магазин повинен мати медіатор, який забезпечує зв'язок між каталогом автомобілів та кошиком для покупок.

4.	Інтернет-магазин повинен мати перекладач для фільтрації автомобілів на основі критеріїв користувача.

5.	Інтернет-магазин повинен надавати користувацький інтерфейс для взаємодії з клієнтами.

6.	Інтернет-магазин повинен відображати загальну вартість кошика.

Результати роботи:
1.	Працюючий інтернет-магазин, який дозволяє клієнтам переглядати та фільтрувати доступні автомобілі.

2.	Кошик, який дозволяє клієнтам додавати та видаляти автомобілі з кошика.

3.	Посередник для взаємодії між каталогом автомобілів та кошиком для покупок.

4.	Інтерпретатор для фільтрації автомобілів на основі критеріїв користувача.

Обмеження:
1.	Веб-магазин повинен бути розроблений з використанням мови програмування C#.

2.	Веб-магазин повинен використовувати патерни проектування Interpreter та Mediator.

3.	Веб-магазин повинен бути протестований для забезпечення належної функціональності та обробки помилок.

4.	Веб-магазин повинен бути розроблений відповідно до галузевих стандартів кодування та інструкцій.


Шаблон Interpreter використовується для створення мови, специфічної для домену (DSL), для фільтрації автомобілів на основі певних критеріїв. DSL дозволить клієнтам шукати автомобілі за маркою, моделлю, роком випуску та ціновим діапазоном. 

Шаблон Mediator використовується для розділення компонентів інтернет-магазину і дозволяє їм взаємодіяти один з одним через посередника. Посередник забезпечує зв'язок між компонентами, такими як інтерпретатор фільтрів, каталог автомобілів і кошик.

У цьому коді клас Car представляє автомобіль, який має марку, модель, рік випуску та ціну. Клас WebShop є основним класом, який використовує паттерн Mediator для фільтрації автомобілів на основі різних критеріїв і паттерн Interpreter для інтерпретації виразів фільтрації. Клас ShoppingCart представляє кошик користувача, в який можна додавати або видаляти автомобілі.

У клієнтському коді створюється список автомобілів, і WebShop екземпляр зі списком автомобілів. WebShop фільтрує автомобілі за маркою, додає перший автомобіль до кошика, фільтрує автомобілі за роком випуску, а потім видаляє перший автомобіль з кошика.
