   M S B A M L   `   `   `  ����N  JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel  5      *    $BNACTMFormGenerator.Views.PasoSPView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :vm+clr-namespace:BNACTMFormGenerator.ViewModel     5      $	��300��5      $	��630��6     � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $! ..\MainWindowResources.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $	��110 �6   .+�5$   
   �� $��0��6   $��0��6$   $��	PASO N° ��61   $��Right=�6A   $
��Bold"�6]   ��5%      �� 5&       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5'      �  � Color$ 	#FFE0E7EA��6#    � Offset$ 0Q�65   � 5(      $ 	#FF7DD0F5��6#   $ 1Q�65   5)      5+      �� 5,   
   $��1��6   $��0��6"   $
��Left=�6H   $
��Bold"�6c   ��6/   �� *	NroPaso+.��6u   ��5-      �� 5.      $ 0.5,1&�6&   $ 0.5,0&�67   .��5/      � $ 	#FFE0E7EA��6#   $ 0Q�65   � 50      $ 	#FF7DD0F5��6#   $ 1Q�65   51      .��52   "   53      �� 55   
   $��0��6   $��1��6    $��Servidor Test:��6-   �� 56   
   $��1��6   $��1��57      $
��Left=�58      $	��400��59      $��21��5:      $	��Top=�5;       '  #ToolTipWithErrorMessageOnErrorStyle#��[  5=      ��5<      �� *ServidorTest+	 �� Mode$	 TwoWay=�
 �� ValidatesOnDataErrors
 .  �� NotifyOnValidationError . 5=      �� 5?   
   $��0��6   $��2��6    $��Servidor Prod:��6-   �� 5@   
   $��1��6   $��2��5A      $
��Left=�5B      $	��400��5C      $��21��5D      $	��Top=�5E      #��[  5G      ��5F      �� *ServidorProd+$	 TwoWay=�
 .  . 5G      �� 5H   
   $��0��6   $��3��6    $��Base de Datos Test:��6-   �� 5I   
   $��1��6   $��3��5J      $
��Left=�5K      $	��200��5L      $��21��5M      $	��Top=�5N      #��[  5P      ��5O      �� *BaseDatosTest+$	 TwoWay=�
 .  . 5P      �� 5R   
   $��0��6   $��4��6    $	��133��6-   $��Base de Datos Prod.:��69   �� 5S   
   $��1��6   $��4��5T      $
��Left=�5U      $	��200��5V      $��21��5W      $	��Top=�5X      #��[  5Z      ��5Y      �� *BaseDatosProduccion+$	 TwoWay=�
 .  . 5Z      �� 5\   
   $��0��6   $��5��6    $	��133��6-   $��Usuario de Ejecución:��69   �� 5]   
   $��1��6   $��5��5^      $
��Left=�5_      $	��200��5`      $��21��5a      $	��Top=�5b       �� SelectedValuePath$ Content��5c       / +ComboBoxToolTipWithErrorMessageOnErrorStyle#��[ 5e       �� SelectedValue 5d      �� *UsuarioEjecucion+$	 TwoWay=�
 .  .  �� UpdateSourceTrigger$ PropertyChanged=�.@�5f      �� .��6   	STAGING6$   �� 5g      .��6   SIEBEL6#   5h      �� 5j   
   $��0��6   $��6��6    $��Stored Procedure:��6-   �� 5k   
   $��1��6   $��6��5l      $��21��5m      $	��Top=�5n      #��[  5p      ��5o      �� *StoredProcedure+$	 TwoWay=�
 .  . 5p      �� 5r   
   $��0��6   $��7��6    $��Parametros:��6-   �� 5s   
   $��1��6   $��7��6"   ��6/   �� *
NewParam+$	 TwoWay=�$ PropertyChanged=��� 5t   
   $��1��6   $��8��6"   $	��100��6y   ��6/   �� *
Parametros+ �� SelectedItem 6R   �� *SelectedParam+6y   �� 5u   
   $��2��6   $��7��6!   $��Agregar��6K   $��20��6]   ��6.   �� *
AddParam+6]   �� 5v   
   $��3��6   $��7��6!   $��Eliminar��6K   $��20��6^   ��6.   �� *
DelParam+6^   5x      5y      