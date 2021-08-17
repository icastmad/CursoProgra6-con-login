
 declare type VueClass<V> = {
    new (...args: any[]): V & Vue;
} & typeof Vue;
 declare type DecoratedClass = VueClass<Vue> & {
    __decorators__?: ((options: ComponentOptions<Vue>) => void)[];
};
