   M S B A M L   `   `   `  ����N  JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel  5      +    %BNACTMFormGenerator.Views.PasoJobView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :vm+clr-namespace:BNACTMFormGenerator.ViewModel     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $! ..\MainWindowResources.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��110 �6   .+�5"   
   �� $��0��6   $��0��6$   $��	PASO N° ��61   $��Right=�6A   $
��Bold"�6]   ��5#      �� 5$       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5%      �  � Color$ 	#FFE0E7EA��6#    � Offset$ 0Q�65   � 5&      $ 	#FF7DD0F5��6#   $ 1Q�65   5'      5)      �� 5*   
   $��1��6   $��0��6"   $
��Left=�6H   $
��Bold"�6c   ��6/   �� *	NroPaso+.��6u   ��5+      �� 5,      $ 0.5,1&�6&   $ 0.5,0&�67   .��5-      � $ 	#FFE0E7EA��6#   $ 0Q�65   � 5.      $ 	#FF7DD0F5��6#   $ 1Q�65   5/      .��50   "   51      �� 53   
   $��0��6   $��1��6    $��Servidor Test:��6-   �� 54   
   $��1��6   $��1��55      $
��Left=�56      $	��400��57      $��21��58      $	��Top=�59       '  #ToolTipWithErrorMessageOnErrorStyle#��[  5;      ��5:      �� *ServidorTest+	 �� Mode$	 TwoWay=�
 �� ValidatesOnDataErrors
 .  �� NotifyOnValidationError . 5;      �� 5=   
   $��0��6   $��2��6    $��Servidor Prod:��6-   �� 5>   
   $��1��6   $��2��5?      $
��Left=�5@      $	��400��5A      $��21��5B      $	��Top=�5C      #��[  5E      ��5D      �� *ServidorProd+$	 TwoWay=�
 .  . 5E      �� 5F   
   $��0��6   $��3��6    $��Nombre Job CTM Test:��6-   �� 5G   
   $��1��6   $��3��5H      $
��Left=�5I      $	��200��5J      $��21��5K      $	��Top=�5L      #��[  5N      ��5M      �� *NombreJobCTMTest+$	 TwoWay=�
 .  . 5N      �� 5P   
   $��0��6   $��4��6    $	��133��6-   $��Nombre Job CTM Prod:��69   �� 5Q   
   $��1��6   $��4��5R      $
��Left=�5S      $	��200��5T      $��21��5U      $	��Top=�5V      #��[  5X      ��5W      �� *NombreJobCTMProd+$	 TwoWay=�
 .  . 5X      �� 5Z   
   $��0��6   $��5��6    $��Parametros:��6-   �� 5[   
   $��1��6   $��5��6"   ��6/   �� *
NewParam+$	 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5\   
   $��1��6   $��6��6"   $	��100��6y   ��6/   �� *
Parametros+ �� SelectedItem 6R   �� *SelectedParam+6y   �� 5]   
   $��2��6   $��5��6!   $��Agregar��6K   $��20��6]   ��6.   �� *
AddParam+6]   �� 5^   
   $��3��6   $��5��6!   $��Eliminar��6K   $��20��6^   ��6.   �� *
DelParam+6^   5`      5a      