   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5      $    WpfApplication2.addProductPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication2     5        N� Title$  addProductPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��New Product��6   $��1��6'   $��Calibri)�67   $��22(�6L   $��40,20,10,10q�6Z   $
��Bold"�6o   �� 5   
   $��1��6   $��Center=�6"   $��Center=�6=   .+�5      �  � ColumnDefinitions 5      �� 5      $��2* �6'   �� 5      $��4* �6'    5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5       �� $��Product Name :��6   $��Right=�61   $��5q�6M   $��16(�6X   �� 5!      $��Quantity(Box) :��6   $��Right=�63   $��1��6O   $��5q�6\   $��16(�6g   �� 5"      $��Price per Box :��6   $��Right=�63   $��2��6O   $��5q�6\   $��16(�6g   �� 5#      $��Quantity per Box :��6   $��Right=�66   $��3��6R   $��5q�6_   $��16(�6j   �� 5$      $��Manufacturer :��6   $��Right=�61   $��4��6M   $��5q�6Z   $��16(�6e   �� 5&      -   5        $��productNameTextBox��5&      $��1��64   $��5,5,5,10q�6D   $	��200��6V   $
��Left=�6b   $��16(�6}   �� 5'      -   5        $��quantityTextBox��5'      $��0��61   $��1��6f   $��1��6s   $��5,5,5,10q�6�   $	��200��6�   $
��Left=�6�   $��16(�6�   �� 5(      -   5        $��pricePBoxTextBox��5(      $��2��6]   $��1��6j   $��5,5,5,10q�6{   $	��200��6�   $
��Left=�6�   $��16(�6�   �� 5)      -   5        $��quantityPBoxTextBox��5)      $��3��6a   $��1��6n   $��5,5,5,10q�6   $	��200��6�   $
��Left=�6�   $��16(�6�   �� 5*      -   5        $��manufacturerTextBox��5*      $��4��65   $��1��6B   $��5,5,5,10q�6S   $	��200��6e   $
��Left=�6q   $��16(�6�   �� 5+      -   5        $��saveNewProductButton��5+      $
��Save��65   $��1��6D   $��5��6T   $��	5,20,5,10q�6a   $��25��6t   $��75��6�   $
��Left=�6�   6�   �� 5,      -   5        $��errorMessage��5,      $�� ��60   $��1��68   $��6��6H   
���  ��6U   5-      5/      50      52      