   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5      '    !WpfApplication2.refillProductPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication2     5      -   5          N� Title$  refillProductPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Refill Product��6   $��1��6*   $��Calibri)�6:   $��22(�6O   $��40,20,10,10q�6]   $
��Bold"�6r   �� 5   
   $��1��6   $��Center=�6"   $��Center=�6=   .+�5      �  � ColumnDefinitions 5      �� 5      $��2* �6'   �� 5      $��4* �6'    5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��Product Name :��6   $��Right=�61   $��5q�6M   $��16(�6X   �� 5       $��Quantity(Box) :��6   $��Right=�63   $��1��6O   $��5q�6\   $��16(�6g   �� 5"      -   5        $��productNameComboBox��5"      $��1��66   $��5,5,5,10q�6F   $	��200��6X   $
��Left=�6d   $��16(�6    �� 
IsEditable . 6�   �� 5#      -   5        $��quantityTextBox��5#      $��0��61   $��1��6f   $��1��6s   $��5,5,5,10q�6�   $	��200��6�   $
��Left=�6�   $��16(�6�   �� 5$      -   5        $��addProductButton��5$      $	��Add��61   $��1��6?   $��2��6O   $��	5,20,5,10q�6\   $��25��6o   $��75��6{   $
��Left=�6�   6�   �� 5%      -   5        $��errorMessage��5%      $�� ��60   $��1��68   $��3��6H   
���  ��6U   5&      5(      5)      5+      