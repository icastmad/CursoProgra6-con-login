

 declare const noop: () => void;
 declare const hasProto: boolean;
 interface VueDecorator {
    (Ctor: typeof Vue): void;
    (target: Vue, key: string): void;
    (target: Vue, key: string, index: number): void;
}
declare namespace VueClassComponent {
export function createDecorator(factory: (options: ComponentOptions<Vue>, key: string, index: number) => void): VueDecorator;
}

 //declare function mixins<A>(CtorA: VueClass<A>): VueClass<A>;
 //declare function mixins<A, B>(CtorA: VueClass<A>, CtorB: VueClass<B>): VueClass<A & B>;
 //declare function mixins<A, B, C>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>): VueClass<A & B & C>;
 //declare function mixins<A, B, C, D>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>, CtorD: VueClass<D>): VueClass<A & B & C & D>;
 //declare function mixins<A, B, C, D, E>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>, CtorD: VueClass<D>, CtorE: VueClass<E>): VueClass<A & B & C & D & E>;
 //declare function mixins<T>(...Ctors: VueClass<Vue>[]): VueClass<T>;
 declare function isPrimitive(value: any): boolean;
 declare function warn(message: string): void;

 interface ImixinsExtends {
  <A>(CtorA: VueClass<A>): VueClass<A>;
  <A, B>(CtorA: VueClass<A>, CtorB: VueClass<B>): VueClass<A & B>;
  <A, B, C>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>): VueClass<A & B & C>;
  <A, B, C, D>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>, CtorD: VueClass<D>): VueClass<A & B & C & D>;
  <A, B, C, D, E>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>, CtorD: VueClass<D>, CtorE: VueClass<E>): VueClass<A & B & C & D & E>;
  <T>(...Ctors: VueClass<Vue>[]): VueClass<T>;

}

