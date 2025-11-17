# Calculator
Calculator-pro

Непростой калькулятор в Unity по MVP.
View рисует UI, Presenter координирует события и логику, Model (через Service) считает и хранит данные. Поддерживает разные операции (+,-,*,/. Настройка доступных операций из SO-конфига), историю, ошибки и сохранения.

## СТРУКТУРА
- **Bootstrap**: Bootstrapper.cs — entry point.
- **Views**: CalculatorView.cs — главная вью с саб-вьюшками (input, button, history, error). ExpressionHistoryView.cs — скролл с текстами истории.
- **Services**: CalculatorService.cs — расчёты, операции. SaveService.cs — save/load.
- **Presenters**: CalculatorPresenter.cs — связывает вью и сервис, обрабатывает кнопки и сопутствующую им логику.
- **Config**: CalculatorConfig.cs — ScriptableObject с доступными операциями и прочими настройками.

## Как улучшить
Внедрить DI, дабы не вручную прокидывать зависимости.
Для истории использовать ObjectPool вместо Instantiate, чтоб не мусорить памятью.
Разбить ICalculatorView на мелкие интерфейсы (по ISP), чтоб не тащить лишнее.

Не совсем корректно разбил модули. Исходил в первую очередь из идеи модуль<=>фича.

https://drive.google.com/file/d/1eTlbC5MX9Ibys7A3H_UzYOZXneMhXKgY/view?usp=drive_link
