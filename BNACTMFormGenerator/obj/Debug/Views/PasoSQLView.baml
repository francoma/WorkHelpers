   M S B A M L   `   `   `  ����N  JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel  5      +    %BNACTMFormGenerator.Views.PasoSQLView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :vm+clr-namespace:BNACTMFormGenerator.ViewModel     5      $	��540��5      $	��490��6+     � 	Resources  5       �� Source�� 5	   
   $! ..\MainWindowResources.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��300 �6   .+�5   
   �� $��0��6   $��0��6$   $��	PASO N° ��61   $��Right=�6A   $
��Bold"�6]   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFE0E7EA��6#    � Offset$ 0Q�65   � 5       $ 	#FF7DD0F5��6#   $ 1Q�65   5!      5#      �� 5$   
   $��1��6   $��0��6"   $
��Left=�6H   $
��Bold"�6c   ��6/   �� *	NroPaso+.��6u   ��5%      �� 5&      $ 0.5,1&�6&   $ 0.5,0&�67   .��5'      � $ 	#FFE0E7EA��6#   $ 0Q�65   � 5(      $ 	#FF7DD0F5��6#   $ 1Q�65   5)      .��5*   "   5+      �� 5-   
   $��0��6   $��1��6    $��Servidor Test:��6-   �� 5.   
   $��1��6   $��1��5/      $
��Left=�50      $	��400��51      $��21��52      $	��Top=�53       '  #ToolTipWithErrorMessageOnErrorStyle#��[  55      ��54      �� *ServidorTest+ �� Mode$ TwoWay=�	 �� ValidatesOnDataErrors	 . 
 �� NotifyOnValidationError
 . 55      �� 57   
   $��0��6   $��2��6    $��Servidor Prod:��6-   �� 58   
   $��1��6   $��2��59      $
��Left=�5:      $	��400��5;      $��21��5<      $	��Top=�5=      #��[  5?      ��5>      �� *ServidorProd+$ TwoWay=�	 . 
 . 5?      �� 5A   
   $��0��6   $��3��6    $��Base de Datos Test:��6-   �� 5B   
   $��1��6   $��3��5C      $
��Left=�5D      $	��200��5E      $��21��5F      $	��Top=�5G      #��[  5I      ��5H      �� *BaseDatosTest+$ TwoWay=�	 . 
 . 5I      �� 5K   
   $��0��6   $��4��6    $	��133��6-   $��Base de Datos Prod.:��69   �� 5L   
   $��1��6   $��4��5M      $
��Left=�5N      $	��200��5O      $��21��5P      $	��Top=�5Q      #��[  5S      ��5R      �� *BaseDatosProduccion+$ TwoWay=�	 . 
 . 5S      �� 5U   
   $��0��6   $��5��6    $	��133��6-   $��Usuario de Ejecución:��69   �� 5V   
   $��1��6   $��5��5W      $
��Left=�5X      $	��200��5Y      $��21��5Z      $	��Top=�5[       �� SelectedValuePath$ Content��5\       / +ComboBoxToolTipWithErrorMessageOnErrorStyle#��[ 5^       �� SelectedValue 5]      �� *UsuarioEjecucion+$ TwoWay=�	 . 
 .  �� UpdateSourceTrigger$ PropertyChanged=�.@�5_      �� .��6   	STAGING6$   �� 5`      .��6   SIEBEL6#   5a      �� 5c   
   $��0��6   $��2��6    $��6��64   $	��SQL��6A   �� 5d   
   $��0��6   $��2��5e      $��7��5f      $	��300��5g      $	��Top=�5h       �� AcceptsReturn . #��[  5k      ��5j      �� *
TextoSQL+$ TwoWay=�	 . 
 . 5k      5l      5m      