   M S B A M L   `   `   `  ���� J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  $    WpfApplication2.addProductPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:WpfApplication2       N� Title$  addProductPage��.���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��New Product��$��1��$��Calibri)�$��22(�$��40,20,10,10q�$
��Bold"��� $��1��$��Center=�$��Center=�.+��  � ColumnDefinitions �� $��2* ��� $��4* � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��Product Name :��$��Right=�$��5q�$��16(��� $��Quantity(Box) :��$��Right=�$��1��$��5q�$��16(��� $��Price per Box :��$��Right=�$��2��$��5q�$��16(��� $��Quantity per Box :��$��Right=�$��3��$��5q�$��16(��� $��Manufacturer :��$��Right=�$��4��$��5q�$��16(��� -   $��productNameTextBox��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(��� -   $��quantityTextBox��$��0��$��1��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(��� -   $��pricePBoxTextBox��$��2��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(��� -   $��quantityPBoxTextBox��$��3��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(��� -   $��manufacturerTextBox��$��4��$��1��$��5,5,5,10q�$	��200��$
��Left=�$��16(��� -   $��saveNewProductButton��$
��Save��$��1��$��5��$��	5,20,5,10q�$��25��$��75��$
��Left=��� -   $��errorMessage��$�� ��$��1��$��6��
���  ��