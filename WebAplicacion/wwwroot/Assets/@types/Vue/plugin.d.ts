

 type PluginFunction<T> = (Vue:Vue, options?: T) => void;

 interface PluginObject<T> {
  install: PluginFunction<T>;
  [key: string]: any;
}
